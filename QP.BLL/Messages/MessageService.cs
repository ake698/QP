using AutoMapper;
using QP.Bussiness.Messages;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;

namespace QP.BLL.Messages
{
    public class MessageService : BaseService<Message, MessageDto>, IMessageService
    {
        public MessageService(IBaseRepository<Message> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
