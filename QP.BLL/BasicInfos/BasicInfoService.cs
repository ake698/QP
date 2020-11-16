using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using QP.Vo;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QP.BLL
{
    public class BasicInfoService : BaseService<VideoBasicInfo, BasicInfoDto>, IBasicInfoService
    {
        private readonly IBaseRepository<VideoBasicInfo> _repository;
        private readonly IMapper _mapper;

        public BasicInfoService(IBaseRepository<VideoBasicInfo> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<PageResultDto<BasicInfoDto>> GetListPageAsync(int seriesId, VodQueryVo vo)
        {
            var datas = _repository.GetAllAsync()
                .Where(x => x.SeriesTypeId == seriesId);
            if (vo.CategoryId.HasValue)
                datas = datas.Where(x => x.CategoryTypeId == vo.CategoryId.Value);
            if (!string.IsNullOrEmpty(vo.AreaName))
                datas = datas.Where(x => x.Area == vo.AreaName);
            if (!string.IsNullOrEmpty(vo.Year))
                datas = datas.Where(x => x.Year == vo.Year);
            if (!string.IsNullOrEmpty(vo.Letter))
                datas = datas.Where(x => x.En.StartsWith(vo.Letter));
            return await PageAsync(datas, vo.Page);
        }
    }
}
