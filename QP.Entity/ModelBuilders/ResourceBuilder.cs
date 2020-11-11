using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class ResourceBuilder
    {
        public ResourceBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<Resource>();
            b.ToTable("data_Resource");
            b.BuilderBaseEntity();
        }
    }
}
