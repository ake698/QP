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
                .WithMany(p => p.VideoPlayInfos)
                .IsRequired()
                .HasForeignKey(p => p.BasicInfoId);

            b.HasOne(p => p.Resource)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.ResourceId);
        }
    }
}
