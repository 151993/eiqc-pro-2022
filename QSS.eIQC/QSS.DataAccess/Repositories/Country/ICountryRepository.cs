using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Country 
    /// </summary>
    public interface ICountryRepository
    {
        Task<Country> AddAsync(Country country, string changeReason);

        Task<Country> UpdateAsync(Country country, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
