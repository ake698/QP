using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QP.BLL
{
    public abstract class BaseService<T, R> : IBaseService<T, R> where T : BaseEntity where R:BaseDto
    {
        private readonly IBaseRepository<T> _repository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<T> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<R> GetAsync(int id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<R>(entity);
        }

        public async Task<List<R>> GetListAsync()
        {
            var entities =await _repository.GetAllAsync().ToListAsync();
            return _mapper.Map<List<R>>(entities);
        }

        public async Task<List<R>> GetListAsync(Expression<Func<T, bool>> predicate)
        {
            var entities = await _repository.GetAllAsync()
                .Where(predicate)
                .ToListAsync();
            return _mapper.Map<List<R>>(entities);
        }

        public async Task<List<R>> GetListOrderBy<Tkey>(Expression<Func<T, bool>> wherePredicate = null, Expression<Func<T, Tkey>> orderPredicate = null, bool asc = false, int size = -1)
        {
            var entities = _repository.GetByPredicate(wherePredicate);
            if(orderPredicate != null)
                entities = asc ? entities.OrderBy(orderPredicate) : entities.OrderByDescending(orderPredicate);
            if (size > 0)
                entities = entities.Take(size);
            return _mapper.Map<List<R>>(await entities.ToListAsync());
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PageResultDto<R>> GetListPageAsync<TKey>(Expression<Func<T, bool>> wherePredicate = null, Expression<Func<T, TKey>> orderPredicate = null, int page = 1, int pageSize = 10, int pageListSize = 5, bool asc = false)
        {
            var datas = _repository.GetByPredicate(wherePredicate);
            if (orderPredicate != null)
                datas = asc ? datas.OrderBy(orderPredicate) : datas.OrderByDescending(orderPredicate);
            var curPageData = await _repository.PageAsync(datas, pageSize, page).ToListAsync();
            var dataCounts = datas.Count();
            var maxPage = dataCounts / pageSize;
            if (dataCounts % pageSize != 0)
                maxPage++;
            return new PageResultDto<R>
            {
                Datas = _mapper.Map<List<R>>(curPageData),
                DataCounts = dataCounts,
                CurrentPage = page,
                PageSize = pageSize,
                MaxPage = maxPage,
                Pages = CaculatePages(page, maxPage, pageListSize)
            };
        }

        private int[] CaculatePages(int currentPage, int maxPage, int pageListSize)
        {
            if (currentPage > maxPage)
                currentPage = 1;

            if (pageListSize % 2 != 1)
                pageListSize++;

            if (maxPage < pageListSize)
                return Enumerable.Range(1, pageListSize).ToArray();

            int midPage = pageListSize / 2;
            
            // （1-pageListSize）
            if(currentPage <= midPage + 1)
                return Enumerable.Range(1, pageListSize).ToArray();

            // (? -maxPage)
            if (currentPage >= maxPage - midPage)
                return Enumerable.Range(maxPage - pageListSize + 1, pageListSize).ToArray();

            return Enumerable.Range(currentPage - midPage, pageListSize).ToArray();

        }

    }
}
