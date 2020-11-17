using QP.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IBaseService<T, R>
    {
        Task<R> GetAsync(int id);

        Task<List<R>> GetListAsync();

        Task<List<R>> GetListAsync(Expression<Func<T, bool>> predicate);

        Task<List<R>> GetListOrderByAsync<TKEY>(Expression<Func<T, bool>> wherePredicate = null, Expression<Func<T, TKEY>> orderPredicate = null, bool asc = false, int size = -1);

        Task SoftDeleteAsync(int id);

        Task DeleteAsync(int id);

        Task<PageResultDto<R>> GetListPageAsync<TKey>(Expression<Func<T, bool>> wherePredicate = null, Expression<Func<T, TKey>> orderPredicate = null, int page = 1, int pageSize = 10, int pageListSize = 5, bool asc = false);

        Task<PageResultDto<R>> PageAsync(IQueryable<T> datas, int page = 1, int pageSize = 10, int pageListSize = 5);

        //Task<R> UpdateAsync(U u);
    }
}
