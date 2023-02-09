using System.Threading.Tasks;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{ /// <summary>
  /// Repository Interface for Location 
  /// </summary>
    public interface ILocationRepository
    {
        Task<Location> AddAsync(Location location, string changeReason);

        Task UpdateAsync(Location location, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
