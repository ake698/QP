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

            b.HasOne(p => p.CategoryType)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.CategoryTypeId);

        }
    }
}
