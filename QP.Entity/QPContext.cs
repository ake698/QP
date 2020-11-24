using Microsoft.EntityFrameworkCore;
using QP.Entity.ModelBuilders;
using System.Diagnostics.CodeAnalysis;

namespace QP.Entity
{
    public class QPContext : DbContext
    {
        public QPContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new SeriesTypeBuilder(builder);
            new ResourceBuilder(builder);
            new CategoryBuilder(builder);
            new VideoBasicInfoBuilder(builder);
            new VideoPlayInfoBuilder(builder);
            new MessageBuilder(builder);
        }

        public DbSet<SeriesType> SeriesTypes { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<VideoBasicInfo> VideoBasicInfos { get; set; }
        public DbSet<VideoPlayInfo> VideoPlayInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
