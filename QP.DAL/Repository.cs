﻿using Microsoft.EntityFrameworkCore;
using QP.Entity;
using QP.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QP.DAL
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly QPContext _db;
        public Repository(QPContext db)
        {
            _db = db;
        }


        public async Task<T> GetAsync(int id)
        {
            var entity = await GetAllAsync().FirstOrDefaultAsync(m => m.Id == id);
            //if (entity == null) throw new BussinessException($"There is no {typeof(T).Name} Entity with id = {id}");
            return entity;
        }
        public virtual async Task<T> CreateAsync(T model, bool saved = true)
        {
            var m = _db.Set<T>().Add(model);
            if (saved) await Save();
            return m.Entity;
        }

        public virtual async Task<List<T>> CreateListAsync(List<T> models, bool saved = true)
        {
            List<T> ms = new List<T>();
            models.ForEach(async x => { T m = await CreateAsync(x, false); ms.Add(x); });
            if (saved) await Save();
            return ms;
        }

        public virtual async Task<T> DeleteAsync(T model, bool softDelete = true, bool saved = true)
        {
            var m = await DeleteAsync(model.Id, softDelete, saved);
            return m;
        }

        public virtual async Task<T> DeleteAsync(int id, bool softDelete = true, bool saved = true)
        {

            T t = await GetAsync(id);
            if (softDelete)
            {
                _db.Entry(t).State = EntityState.Modified;
                t.IsDelete = true;
            }
            else
                _db.Entry(t).State = EntityState.Deleted;
            if (saved)
            {
                await Save();
            }
            return t;
        }

        public virtual async Task<T> PatchAsync(T model, bool saved = true)
        {
            _db.Entry(model).State = EntityState.Modified;
            if (saved)
            {
                await Save();
            }
            return model;
        }

        public virtual async Task<T> UpdateAsync(T model, bool saved = true)
        {
            _db.Entry(model).State = EntityState.Modified;
            if (saved)
            {
                await Save();
            }
            return model;
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }

        #region 查询
        public IQueryable<T> GetAllAsync()
        {
            return _db.Set<T>().Where(m => !m.IsDelete).AsNoTracking();
        }

        public IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0)
        {
            return GetAllAsync().Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrderAsync(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetByPredicate(Expression<Func<T, bool>> predicate)
        {
            return GetAllAsync().Where(predicate);
        }

        public IQueryable<T> GetAllOrderAsync(bool asc = true)
        {
            var datas = GetAllAsync();
            datas = asc ? datas.OrderBy(m => m.Id) : datas.OrderByDescending(m => m.Id);
            return datas;
        }
        #endregion

    }
}
