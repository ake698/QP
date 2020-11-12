using AutoMapper;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System;

namespace QP.BLL
{
    public class CategoryService : BaseService<CategoryType,CategoryTypeDto>, ICategoryService
    {
        private readonly IBaseRepository<CategoryType> _repository;
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<CategoryType> repository, IMapper mapper):base(repository, mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
