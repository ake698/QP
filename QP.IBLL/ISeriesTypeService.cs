using QP.Bussiness;
using QP.Entity;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface ISeriesTypeService : IBaseService<SeriesType,SeriesTypeDto>
    {
        Task<SeriesTypeDto> GetAsync(string seriesEn);
    }
}
