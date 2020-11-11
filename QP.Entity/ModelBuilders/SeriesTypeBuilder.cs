using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class SeriesTypeBuilder
    {
        public SeriesTypeBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<SeriesType>();
            b.ToTable("data_Series");
            b.BuilderBaseEntity();
        }
    }
}
