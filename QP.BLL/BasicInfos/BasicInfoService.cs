using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using QP.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QP.BLL
{
    public class BasicInfoService : BaseService<VideoBasicInfo, BasicInfoDto>, IBasicInfoService
    {
        private readonly IBaseRepository<VideoBasicInfo> _repository;
        private readonly IList<string> hosts = new List<string>
        {
            "http://ak.aiqianpin.cn/",
            "http://bot.aiqianpin.cn/",
        };

        public BasicInfoService(IBaseRepository<VideoBasicInfo> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<PageResultDto<BasicInfoDto>> GetListPageAsync(int seriesId, VodQueryVo vo)
        {
            var datas = _repository.GetAll()
                .Where(x => x.SeriesTypeId == seriesId);
            if (vo.CategoryId.HasValue)
                datas = datas.Where(x => x.CategoryTypeId == vo.CategoryId.Value);
            if (!string.IsNullOrEmpty(vo.AreaName))
                datas = datas.Where(x => x.AreaName == vo.AreaName);
            if (!string.IsNullOrEmpty(vo.Year))
                datas = datas.Where(x => x.Year == vo.Year);
            //if (!string.IsNullOrEmpty(vo.Letter))
            //    datas = datas.Where(x => x.En.StartsWith(vo.Letter));
            datas = datas.OrderByDescending(x => x.LastModificationTime);
            return await PageAsync(datas, vo.Page, 24);
        }

        public async Task<List<BasicInfoDto>> GetListRecommendsAsync(int id, string dierctor, string actor, string en, float rate, int size = 10)
        {
            List<BasicInfoDto> recommends;
            if (string.IsNullOrWhiteSpace(dierctor) || string.IsNullOrWhiteSpace(actor))
                recommends = await GetListOrderByAsync(x => x.Rate == rate || x.En.StartsWith(en.Substring(0, 3)), x => x.Count, false, size + 1);
            else
                recommends = await GetListOrderByAsync(wherePredicate: x => x.Actor == actor || x.Dierctor == dierctor || x.En.StartsWith(en.Substring(0, 3)), orderPredicate: x => x.Count, size: size + 1);
            return recommends.Where(x => x.Id != id).ToList();
        }

        public async Task<List<BasicInfoDto>> GetListTopsAsync(int id, int seriesId, int size = 10)
        {
            var tops = await GetListOrderByAsync(x => x.SeriesTypeId == seriesId && x.IsHot && x.Id!=id, x => x.LastModificationTime, false, size);
            if (tops.Count < size)
                tops.AddRange(await GetListOrderByAsync(x => x.SeriesTypeId == seriesId && x.Id != id, x => x.LastModificationTime,false, size-tops.Count));
            return tops;
        }


        public async Task<PageListResultDto<BasicInfoBotSearchDto>> BotSearch(string key)
        {
            var basicInfos = _repository.GetAll()
                .Where(x => x.Name.Contains(key) || x.Alias.Contains(key));

            var count = basicInfos.Count();

            var results = await basicInfos.Take(5)
                .Include(x => x.VideoPlayInfos)
                .Where(x => x.VideoPlayInfos.Count > 0)
                .ToListAsync();

            var random = new Random();
            var host = hosts[random.Next(2)];

            return new PageListResultDto<BasicInfoBotSearchDto>
            {
                Count = count,
                Datas = results.Select(x => new BasicInfoBotSearchDto
                {
                    Name = x.Name,
                    Url = $"{host}/play/{x.Id}-{x.VideoPlayInfos.First().ResourceId}-1.html"
                }).ToList()
            };
        }
    }
}
