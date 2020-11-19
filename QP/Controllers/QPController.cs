using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QP.Bussiness;
using QP.Bussiness.Enums;
using QP.IBLL;
using QP.Models;
using QP.Vo;

namespace QP.Controllers
{

    public class QPController : Controller
    {
        private readonly ILogger<QPController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IBasicInfoService _basicInfoService;
        private readonly ISeriesTypeService _seriesTypeService;
        private readonly IPlayInfoService _playInfoService;

        public QPController(ILogger<QPController> logger, ICategoryService categoryService, IBasicInfoService basicInfoService, ISeriesTypeService seriesTypeService, IPlayInfoService playInfoService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _basicInfoService = basicInfoService ?? throw new ArgumentNullException(nameof(basicInfoService));
            _seriesTypeService = seriesTypeService ?? throw new ArgumentNullException(nameof(seriesTypeService));
            _playInfoService = playInfoService ?? throw new ArgumentNullException(nameof(playInfoService));
        }

        [Route("/")]
        [Route("/index")]
        public async Task<IActionResult> Index()
        {
            var recents = await _basicInfoService.GetListOrderByAsync(orderPredicate:x => x.LastModificationTime, size: 18);
            ViewBag.recents = recents.Take(6).ToList();
            ViewBag.recentsSim = recents.Skip(6).ToList();

            var categoryDtos = await _categoryService.GetListAsync();
            var serieses = await _seriesTypeService.GetListAsync();

            var recommends = new List<IndexTypeViewDto>();
            foreach (var series in serieses)
            {
                var recommend = await _basicInfoService.GetListTopsAsync(0, series.Id, 16);
                recommends.Add(new IndexTypeViewDto
                {
                    RecommendsForMoblie = recommend.Skip(4).Take(2).ToList(),
                    Recommends = recommend.Take(4).ToList(),
                    RecommendTops = recommend.Skip(6).Take(10).ToList(),
                    CategoryTypes = categoryDtos.Where(x => x.SeriesTypeId == series.Id).ToList(),
                    SeriesType = series
                });;
            }
            ViewBag.recommends = recommends;
            return View();
        }


        [Route("/series/{id}")]
        public async Task<IActionResult> Series(int id, [FromQuery]VodQueryVo vo)
        {
            var categories = await _categoryService.GetListAsync(x => x.SeriesTypeId == id);
            var vods = await _basicInfoService.GetListPageAsync(id, vo);
            var series = await _seriesTypeService.GetAsync(id);
            ViewBag.vo = vo;
            ViewBag.categories = categories;
            ViewBag.vods = vods;
            ViewBag.seriesName = series.Name;
            return View();
        }


        [Route("/detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var basicInfo = await _basicInfoService.GetAsync(id);
            var playInfo = await _playInfoService.GetPlayInfos(id);

            // 推荐
            var recommends = await _basicInfoService.GetListRecommendsAsync(id, basicInfo.Dierctor, basicInfo.Actor, basicInfo.En, basicInfo.Rate);
            // 右侧推荐最热
            var tops = await _basicInfoService.GetListTopsAsync(id, basicInfo.SeriesTypeId);
            ViewBag.video = basicInfo;
            ViewBag.play = playInfo;
            ViewBag.tops = tops;
            ViewBag.recommends = recommends;
            return View();
        }

        [Route("/play/{id}")]
        public async Task<IActionResult> Play(int id, VodPlayQueryVo vo)
        {
            var basicInfo = await _basicInfoService.GetAsync(id);
            var playInfo = await _playInfoService.GetPlayInfos(id);
            var currentVod = playInfo
                .Where(x => x.ResourceId == vo.ResourceId)
                .FirstOrDefault();
            // 推荐
            var recommends = await _basicInfoService.GetListRecommendsAsync(id, basicInfo.Dierctor, basicInfo.Actor, basicInfo.En, basicInfo.Rate);
            // 右侧推荐最热
            var tops = await _basicInfoService.GetListTopsAsync(id, basicInfo.SeriesTypeId);
            var currentAddress = "#";
            if(currentVod != null)
            {
                currentAddress = currentVod.PlayAddresses[vo.Number - 1].Split("$")[1];
            }
            ViewBag.video = basicInfo;
            ViewBag.play = playInfo;
            ViewBag.currentAddress = currentAddress;
            ViewBag.currentMax = currentVod.PlayAddresses.Length;
            ViewBag.vo = vo;
            ViewBag.tops = tops;
            ViewBag.recommends = recommends;
            return View();
        }
        
        [Route("/search")]
        public async Task<IActionResult> Search(SearchQueryVo vo)
        {
            var movies = await _basicInfoService.GetListOrderByAsync(x => x.SeriesTypeId == (int)SeriesTypeEnum.Movie, x => x.Count, false, 10);
            var tvs = await _basicInfoService.GetListOrderByAsync(x => x.SeriesTypeId == (int)SeriesTypeEnum.TV, x => x.Count, false, 10);
            var results = await _basicInfoService.GetListPageAsync(wherePredicate: x => x.Name.Contains(vo.Key) || x.En.Contains(vo.Key), orderPredicate:x=>x.Count, page: vo.Page);

            ViewBag.Movies = movies;
            ViewBag.tvs = tvs;
            ViewBag.results = results;
            ViewBag.vo = vo;
            return View();
        }

        [HttpGet("/transfer")]
        public IActionResult Transfer()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
