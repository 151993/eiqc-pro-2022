using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// The <see cref="Repository{TEntity}"/> Interface
    /// </summary>
    /// <typeparam name="TEntity">the Entity Type</typeparam>
    public interface IBaseRepository<TEntity, TType>
    {
        Task<TEntity> AddAsync(TEntity entity, string auditLogTitle, string changeReason);

        Task<TEntity> UpdateAsync(TEntity role, string auditLogTitle, string changeReason);
    }
}
