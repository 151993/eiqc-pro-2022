using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public abstract class Repository<TEntity, TType> : IRepository<TEntity, TType> where TEntity : class
    {
        protected DbSet<TEntity> Entities { get; }

        protected DbContext Context { get; }

        public Repository(DbContext context)
        {
            Context = context;
            Entities = Context.Set<TEntity>();
        }

        public async Task<TEntity> Get(TType id)
        {
            return await Entities.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Entities.ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.SingleOrDefault(predicate);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await Entities.AddAsync(entity);
            return result.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            return Entities.Update(entity).Entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
        }

        public bool Remove(TEntity entity)
        {
            Entities.Remove(entity);
            return true;
        }

        public async Task RemoveById(TType id)
        {
            var entity = await Get(id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);
        }

        public IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            IQueryable<TEntity> query = null;
            foreach (var includeExpression in includeExpressions)
            {
                query = Entities.Include(includeExpression);
            }

            return query ?? Entities;
        }

        public Task<bool> CanSafeToRemove(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
