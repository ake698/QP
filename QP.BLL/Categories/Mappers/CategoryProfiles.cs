using AutoMapper;
using QP.Bussiness;
using QP.Entity;

namespace QP.BLL.Categories.Mappers
{
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<CategoryType, CategoryTypeDto>();
        }
    }
}
