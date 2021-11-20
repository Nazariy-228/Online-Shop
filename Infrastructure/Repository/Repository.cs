using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ShopContext _context;
        private readonly DbSet<TEntity> _entities;

        public Repository(ShopContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = includes
                .Aggregate<Expression<Func<TEntity, object>>, IQueryable<TEntity>>(_entities,
                    (current, include) => current.Include(include));

            return query;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            CheckEntityForNull(entity);

            return (await _entities.AddAsync(entity)).Entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _entities.AddRangeAsync(entities);
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => entities.ToList().ForEach(i => _context.Entry(i).State = EntityState.Deleted));
        }

        public async Task<IEntity> UpdateAsync(TEntity entity)
        {
            return await Task.Run(() => _entities.Update(entity).Entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public ValueTask<TEntity> GetByIdAsync(params object[] keys)
        {
            return _entities.FindAsync(keys);
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        
        public void Detach(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }
        
        private void CheckEntityForNull(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity), "The entity to add cannot be null!");
        }
    }
}