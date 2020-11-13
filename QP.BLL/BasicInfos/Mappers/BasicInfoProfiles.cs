using AutoMapper;
using QP.Bussiness;
using QP.Entity;

namespace QP.BLL.BasicInfos.Mappers
{
    public class BasicInfoProfiles : Profile
    {
        public BasicInfoProfiles()
        {
            CreateMap<VideoBasicInfo, BasicInfoDto>();
        }
    }
}
