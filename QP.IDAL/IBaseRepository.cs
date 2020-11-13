﻿using QP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QP.IDAL
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T model, bool saved = true);
        Task<List<T>> CreateListAsync(List<T> models, bool saved = true);
        Task<T> UpdateAsync(T model, bool saved = true);
        Task<T> PatchAsync(T model, bool saved = true);
        Task<T> DeleteAsync(T model, bool softDelete = true, bool saved = true);
        Task<T> DeleteAsync(int id, bool softDelete = true, bool saved = true);
        Task Save();

        Task<T> GetAsync(int id);
        IQueryable<T> GetAllAsync();
        IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0);
        IQueryable<T> GetByPredicate(Expression<Func<T, bool>> predicate);
        IQueryable<T> PageAsync(IQueryable<T> datas, int pageSize = 10, int pageIndex = 0);
    }
}