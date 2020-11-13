using AutoMapper;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System;

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
    }
}
