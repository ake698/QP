using QP.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IBaseService<T, R>
    {
        Task<R> GetAsync(int id);

        Task<List<R>> GetListAsync();

        Task<List<R>> GetListAsync(Expression<Func<T, bool>> predicate);

        Task<List<R>> GetListOrderBy<TKEY>(Expression<Func<T, bool>> wherePredicate, Expression<Func<T, TKEY>> orderPredicate, bool asc = true, int size = -1);

        Task SoftDeleteAsync(int id);

        Task DeleteAsync(int id);

        Task<PageResultDto<R>> GetListPageAsync(Expression<Func<T, bool>> predicate, int page = 1, int pageSize = 10, int pageListSize = 5);

        //Task<R> UpdateAsync(U u);
    }
}
