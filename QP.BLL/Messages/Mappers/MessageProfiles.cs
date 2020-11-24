using AutoMapper;
using QP.Bussiness.Messages;
using QP.Entity;

namespace QP.BLL.Messages.Mappers
{
    public class MessageProfiles : Profile
    {
        public MessageProfiles()
        {
            CreateMap<Message, MessageDto>();
        }
    }
}
