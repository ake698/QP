using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class VideoBasicInfoBuilder
    {
        public VideoBasicInfoBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<VideoBasicInfo>();
            b.ToTable("Vod_BasicInfo");

            b.BuilderFullEntity();

            b.Property(p => p.IsHot)
                .HasDefaultValue(false);

            b.Property(p => p.Count)
                .HasDefaultValue(0);

            b.HasOne(p => p.CategoryType)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.CategoryTypeId);

        }
    }
}
