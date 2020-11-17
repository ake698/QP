using AutoMapper;
using QP.Bussiness;
using QP.Entity;

namespace QP.BLL.PlayInfos.Mappers
{
    public class PlayInfoProfiles : Profile
    {
        public PlayInfoProfiles()
        {
            CreateMap<VideoPlayInfo, PlayInfoDto>()
                .ForMember(x => x.PlayAddresses, options => options.Ignore());
        }
    }
}
