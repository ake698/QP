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

        public SeriesTypeService(IBaseRepository<SeriesType> repository, IMapper mapper) :base(repository,mapper)
        {
        }
    }
}
