using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class MessageBuilder
    {
        public MessageBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<Message>();
            b.ToTable("data_message");
            b.BuilderBaseEntity();
        }
    }
}
