using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// The <see cref="Repository{TEntity}"/> Interface
    /// </summary>
    /// <typeparam name="TEntity">the Entity Type</typeparam>
    public interface IRepository<TEntity, TType> where TEntity : class
    {
        Task<TEntity> Get(TType id);
        Task<IEnumerable<TEntity>> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> AddAsync(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        bool Remove(TEntity entity);
        Task RemoveById(TType id);
        void RemoveRange(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
        Task<bool> CanSafeToRemove(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
