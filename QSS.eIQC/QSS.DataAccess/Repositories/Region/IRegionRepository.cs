using System.Threading.Tasks;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Region 
    /// </summary>
    public interface IRegionRepository
    {
        Task<Region> AddAsync(Region region, string changeReason);

        Task<Region> UpdateAsync(Region region, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
