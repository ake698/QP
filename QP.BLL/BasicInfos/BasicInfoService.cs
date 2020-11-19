using AutoMapper;
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

        public BasicInfoService(IBaseRepository<VideoBasicInfo> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<PageResultDto<BasicInfoDto>> GetListPageAsync(int seriesId, VodQueryVo vo)
        {
            var datas = _repository.GetAllAsync()
                .Where(x => x.SeriesTypeId == seriesId);
            if (vo.CategoryId.HasValue)
                datas = datas.Where(x => x.CategoryTypeId == vo.CategoryId.Value);
            if (!string.IsNullOrEmpty(vo.AreaName))
                datas = datas.Where(x => x.AreaName == vo.AreaName);
            if (!string.IsNullOrEmpty(vo.Year))
                datas = datas.Where(x => x.Year == vo.Year);
            if (!string.IsNullOrEmpty(vo.Letter))
                datas = datas.Where(x => x.En.StartsWith(vo.Letter));
            return await PageAsync(datas, vo.Page);
        }

        public async Task<List<BasicInfoDto>> GetListRecommendsAsync(int id, string dierctor, string actor, string en, float rate, int size = 10)
        {
            List<BasicInfoDto> recommends;
            if (string.IsNullOrWhiteSpace(dierctor) || string.IsNullOrWhiteSpace(actor))
                recommends = await GetListOrderByAsync(x => x.Rate == rate || x.En.StartsWith(en.Substring(0, 1)), x => x.LastModificationTime, false, size + 1);
            else
                recommends = await GetListOrderByAsync(wherePredicate: x => x.Actor == actor || x.Dierctor == dierctor || x.En.StartsWith(en.Substring(0, 1)), orderPredicate: x => x.LastModificationTime, size: size + 1);
            return recommends.Where(x => x.Id != id).ToList();
        }

        public async Task<List<BasicInfoDto>> GetListTopsAsync(int id, int seriesId, int size = 10)
        {
            var tops = await GetListOrderByAsync(x => x.SeriesTypeId == seriesId && x.IsHot, x => x.LastModificationTime, false, size);
            if (tops.Count < 2)
                tops = await GetListOrderByAsync(x => x.SeriesTypeId == seriesId, x => x.LastModificationTime,false, size);
            tops = tops.Where(x => x.Id != id).ToList();
            return tops;
        }
    }
}
