using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System.Threading.Tasks;

namespace QP.BLL
{
    public class SeriesTypeService: BaseService<SeriesType, SeriesTypeDto> , ISeriesTypeService
    {
        private readonly IBaseRepository<SeriesType> _repository;
        private readonly IMapper _mapper;
        public SeriesTypeService(IBaseRepository<SeriesType> repository, IMapper mapper) :base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<SeriesTypeDto> GetAsync(string seriesEn)
        {
            var seriesType = await _repository.GetAll().FirstOrDefaultAsync(x => x.En == seriesEn);
            return _mapper.Map<SeriesTypeDto>(seriesType);
        }
    }
}
