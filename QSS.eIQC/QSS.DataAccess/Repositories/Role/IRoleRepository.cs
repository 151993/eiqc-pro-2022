using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Role
    /// </summary>
    public interface IRoleRepository
    {
        Task<Role> AddAsync(Role role, string changeReason);

        Task<Role> UpdateAsync(Role role, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
