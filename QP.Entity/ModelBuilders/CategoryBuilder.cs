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

            b.HasData(
                new CategoryType { Id = 6, Name = "动作片", SeriesTypeId = 1 },
                new CategoryType { Id = 7, Name = "喜剧", SeriesTypeId = 1 },
                new CategoryType { Id = 8, Name = "爱情片", SeriesTypeId = 1 },
                new CategoryType { Id = 9, Name = "科幻片", SeriesTypeId = 1 },
                new CategoryType { Id = 10, Name = "恐怖片", SeriesTypeId = 1 },
                new CategoryType { Id = 11, Name = "剧情片", SeriesTypeId = 1 },
                new CategoryType { Id = 12, Name = "战争片", SeriesTypeId = 1 },

                new CategoryType { Id = 13, Name = "国产剧", SeriesTypeId = 2 },
                new CategoryType { Id = 14, Name = "港剧", SeriesTypeId = 2 },
                new CategoryType { Id = 15, Name = "韩剧", SeriesTypeId = 2 },
                new CategoryType { Id = 16, Name = "欧美剧", SeriesTypeId = 2 },
                new CategoryType { Id = 20, Name = "纪录片", SeriesTypeId = 2 },
                new CategoryType { Id = 21, Name = "微电影", SeriesTypeId = 2 },
                new CategoryType { Id = 22, Name = "台湾剧", SeriesTypeId = 2 },
                new CategoryType { Id = 23, Name = "日剧", SeriesTypeId = 2 },

                new CategoryType { Id = 25, Name = "大陆综艺", SeriesTypeId = 3 },
                new CategoryType { Id = 26, Name = "港台综艺", SeriesTypeId = 3 },
                new CategoryType { Id = 27, Name = "日韩综艺", SeriesTypeId = 3 },
                new CategoryType { Id = 28, Name = "欧美综艺", SeriesTypeId = 3 },

                new CategoryType { Id = 29, Name = "国产动漫", SeriesTypeId = 4 },
                new CategoryType { Id = 30, Name = "日韩动漫", SeriesTypeId = 4 },
                new CategoryType { Id = 31, Name = "欧美动漫", SeriesTypeId = 4 },
                new CategoryType { Id = 32, Name = "港台动漫", SeriesTypeId = 4 },
                new CategoryType { Id = 33, Name = "其他", SeriesTypeId = 4 }
            );
        }
    }
}
