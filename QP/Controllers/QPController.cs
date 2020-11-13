using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QP.Bussiness;
using QP.Bussiness.Enums;
using QP.Entity;
using QP.IBLL;
using QP.Models;

namespace QP.Controllers
{

    public class QPController : Controller
    {
        private readonly ILogger<QPController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IBasicInfoService _basicInfoService;

        public QPController(ILogger<QPController> logger, ICategoryService categoryService, IBasicInfoService basicInfoService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _basicInfoService = basicInfoService ?? throw new ArgumentNullException(nameof(basicInfoService));
        }

        [Route("/index")]
        public async Task<IActionResult> Index()
        {
            var recents = await _basicInfoService.GetListOrderBy(orderPredicate:x => x.LastModificationTime, size: 19);
            ViewBag.recents = recents.Take(6);
            ViewBag.recentsSim = recents.Skip(6);

            for (int i = 1; i <= (int)SeriesTypeEnum.VARIETY; i++)
            {

            }
            var categoryDtos = await _categoryService.GetListAsync(x => x.SeriesTypeId == 1);
            ViewBag.category = categoryDtos;
            return View();
        }

        [Route("detail")]
        public IActionResult Detail()
        {
            return View();
        }

        [Route("play")]
        public IActionResult Play()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/test")]
        public async Task<List<CategoryTypeDto>> Test1()
        {
            return await _categoryService.GetListAsync(x => x.SeriesTypeId == 1);
        }
        [HttpGet("/test2")]
        public async Task<PageResultDto<BasicInfoDto>> Test2()
        {
            var recents = await _basicInfoService.GetListOrderBy(null, x => x.LastModificationTime, false, 7);
            var movices = await _basicInfoService.GetListOrderBy(x => x.SeriesTypeId == (int)SeriesTypeEnum.Movie, x => x.LastModificationTime, false, 6);
            var pageDto = await _basicInfoService.GetListPageAsync(orderPredicate:x => x.LastModificationTime);
            return pageDto;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
