using Microsoft.EntityFrameworkCore;

namespace QP.Entity.ModelBuilders
{
    public class VideoBasicInfoBuilder
    {
        public VideoBasicInfoBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<VideoBasicInfo>();
            b.ToTable("Vod_BasicInfo");

            b.BuilderBaseEntity();

            b.Property(p => p.IsHot)
                .HasDefaultValue(false);

            b.Property(p => p.Count)
                .HasDefaultValue(0);

            b.Property(p => p.Rate)
                .HasDefaultValue(8);

            b.HasOne(p => p.CategoryType)
                .WithMany()
                .IsRequired()
                .HasForeignKey(p => p.CategoryTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasIndex(p => p.Name);
            b.HasIndex(p => p.Dierctor);
            b.HasIndex(p => p.Actor);
            b.HasIndex(p => p.En);
            b.HasIndex(p => p.Year);
        }
    }
}
