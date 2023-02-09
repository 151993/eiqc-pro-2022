using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{ /// <summary>
  /// Repository Interface for Manager 
  /// </summary>
    public interface IManagerRepository
    {
        Task<Manager> AddAsync(Manager manager, string changeReason);

        Task UpdateAsync(Manager megion, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        Task<Manager> GetManagerDetailByName(string name);

        Task<User> AddUserManager(User user, string managerName);
    }
}
