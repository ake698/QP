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

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
