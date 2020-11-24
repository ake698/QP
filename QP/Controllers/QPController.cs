using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Session;
using QP.Bussiness;
using QP.Bussiness.Enums;
using QP.IBLL;
using QP.Models;
using QP.Vo;
using Microsoft.AspNetCore.Http;

namespace QP.Controllers
{

    public class QPController : Controller
    {
        private readonly ILogger<QPController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IBasicInfoService _basicInfoService;
        private readonly ISeriesTypeService _seriesTypeService;
        private readonly IPlayInfoService _playInfoService;
        private readonly IMessageService _messageService;

        public QPController(ILogger<QPController> logger, ICategoryService categoryService, IBasicInfoService basicInfoService, ISeriesTypeService seriesTypeService, IPlayInfoService playInfoService, IMessageService messageService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _basicInfoService = basicInfoService ?? throw new ArgumentNullException(nameof(basicInfoService));
            _seriesTypeService = seriesTypeService ?? throw new ArgumentNullException(nameof(seriesTypeService));
            _playInfoService = playInfoService ?? throw new ArgumentNullException(nameof(playInfoService));
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
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

        [HttpGet("/message")]
        public async Task<IActionResult> Message(int page = 1)
        {
            var messages = await _messageService.GetListPageAsync(orderPredicate: x => x.CreationTime, page:page);
            ViewBag.messages = messages;
            return View();
        }

        [HttpPost("/message")]
        public async Task<IActionResult> CreateMessageAsync(CreateMessageVo vo)
        {
            if (!ModelState.IsValid)
                return BadRequest("留言和验证码不能为空！");
            var code = HttpContext.Session.GetString("verify");
            if (!code.Equals(vo.VerifyCode))
                return BadRequest("验证码错误!");

            await  _messageService.CreateAsync(new Entity.Message
            {
                Content = vo.Content
            });

            return Ok("留言成功！");
        }

        [Route("/verify")]
        public IActionResult CreateIntCode()
        {
            string code = new Random().Next(999999).ToString("000000");
            HttpContext.Session.SetString("verify", code);
            using Bitmap image = new Bitmap(76, 32);
            Random random = new Random();
            int min = 70, max = 170;
            Color bg;
            using (Graphics g = Graphics.FromImage(image))
            {
                int bad = random.Next(3);//总有一个颜色分量可能偏深色
                bg = Color.FromArgb(random.Next(bad == 0 ? 120 : 200, 255), random.Next(bad == 1 ? 120 : 200, 255), random.Next(bad == 2 ? 120 : 200, 255));
                g.Clear(bg);
                Font font = new Font("Arial", 18, FontStyle.Bold);
                Color c1 = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                Color c2 = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                //字体由上到下颜色渐变
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 10, 22), c1, c2, 90, true);
                int x = random.Next(-8, -1);
                for (int i = 0; i < code.Length; i++)
                {
                    Matrix transform = g.Transform;
                    //上下波动
                    transform.Shear(0, Convert.ToSingle((random.NextDouble() - 0.5) / 5));
                    g.Transform = transform;
                    x += random.Next(9, 11);
                    g.DrawString(code.Substring(i, 1), font, brush, x, 3);
                    g.ResetTransform();
                }
            }
            using Bitmap destBmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(destBmp))
            {
                // 填充位图背景
                g.FillRectangle(new SolidBrush(bg), 0, 0, destBmp.Width, destBmp.Height);

                double dBaseAxisLen = (double)destBmp.Height;
                double dPhase = 0;
                for (int i = 0; i < destBmp.Width; i++)
                {
                    //干扰线
                    //if ((i % 15) == 1) dPhase = random.NextDouble() * Math.PI * 2;
                    for (int j = 0; j < destBmp.Height; j++)
                    {
                        double dx = Math.PI * j * 2 / dBaseAxisLen + dPhase;
                        double dy = Math.Sin(dx);

                        // 取得当前点的颜色
                        int nOldX = i + (int)(dy * 3);
                        int nOldY = j;

                        Color color = image.GetPixel(i, j);
                        if (nOldX >= 0 && nOldX < destBmp.Width && nOldY >= 0 && nOldY < destBmp.Height)
                        {
                            destBmp.SetPixel(nOldX, nOldY, color);
                        }
                    }
                }
                g.SmoothingMode = SmoothingMode.HighSpeed;
            };
            MemoryStream ms = new MemoryStream();
            destBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] b = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(b, 0, Convert.ToInt32(ms.Length));
            ms.Close();
            return File(b, "image/jpeg");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
