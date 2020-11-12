using AutoMapper;
using QP.Bussiness;
using QP.Entity;

namespace QP.BLL.SeriesTypes.Mappers
{
    public class SeriesProfiles : Profile
    {
        public SeriesProfiles()
        {
            CreateMap<SeriesType, SeriesTypeDto>();
        }
    }
}
