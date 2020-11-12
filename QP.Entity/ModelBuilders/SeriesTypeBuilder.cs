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

            b.HasData(
                new SeriesType
                { Id = 1, Name = "电影" },
                new SeriesType { Id = 2, Name = "电视剧" },
                new SeriesType { Id = 3, Name = "综艺" },
                new SeriesType { Id = 4, Name = "动画" }
            );
        }
    }
}
