using System.Threading.Tasks;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for User 
    /// </summary>
    public interface IUserRepository
    {
        Task<User> AddAsync(User user, string changeReason);

        Task UpdateAsync(User user, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
