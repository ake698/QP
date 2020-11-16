using AutoMapper;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using QP.VO;
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

        public async Task<PageResultDto<BasicInfoDto>> GetListPageAsync(VodQueryVo vo)
        {
            var datas = _repository.GetAllAsync();
            if (vo.CategoryId.HasValue)
                datas.Where(x => x.CategoryTypeId == vo.CategoryId.Value);
            if (!string.IsNullOrEmpty(vo.AreaName))
                datas.Where(x => x.Area == vo.AreaName);
            if (!string.IsNullOrEmpty(vo.Year))
                datas.Where(x => x.Year == vo.Year);
            if (string.IsNullOrEmpty(vo.Letter))
                datas.Where(x => x.En.StartsWith(vo.Letter));
            return await PageAsync(datas, vo.Page);
        }
    }
}
