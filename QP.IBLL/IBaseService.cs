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

        Task SoftDeleteAsync(int id);

        Task DeleteAsync(int id);

        //Task<R> UpdateAsync(U u);
    }
}
