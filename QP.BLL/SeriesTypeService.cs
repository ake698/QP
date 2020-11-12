using AutoMapper;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System;

namespace QP.BLL
{
    public class SeriesTypeService: BaseService<SeriesType, SeriesTypeDto> , ISeriesTypeService
    {
        private readonly IBaseRepository<SeriesType> _repository;
        private readonly IMapper _mapper;

        public SeriesTypeService(IBaseRepository<SeriesType> repository, IMapper mapper) :base(repository,mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
