using Microsoft.EntityFrameworkCore;
using System;

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
                { Id = 1, Name = "电影" ,Icon = "icon_1.png"},
                new SeriesType { Id = 2, Name = "电视剧", Icon = "icon_2.png", CreationTime = DateTime.Now },
                new SeriesType { Id = 3, Name = "综艺", Icon = "icon_3.png", CreationTime = DateTime.Now },
                new SeriesType { Id = 4, Name = "动画", Icon = "icon_4.png", CreationTime = DateTime.Now }
            );
        }
    }
}
