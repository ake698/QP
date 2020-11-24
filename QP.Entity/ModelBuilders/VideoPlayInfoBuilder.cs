using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class VideoPlayInfoBuilder
    {
        public VideoPlayInfoBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<VideoPlayInfo>();
            
            b.ToTable("Vod_PlayInfo");
            b.BuilderBaseEntity();

            b.HasOne(p => p.VideoBasicInfo)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.BasicInfoId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(p => p.Resource)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.ResourceId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
