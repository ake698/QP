using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class CategoryBuilder
    {
        public CategoryBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<CategoryType>();
            b.ToTable("data_Category");

            b.HasOne(p => p.SeriesType)
                .WithMany()
                .HasForeignKey(p => p.SeriesTypeId);
            b.BuilderBaseEntity();
        }
    }
}
