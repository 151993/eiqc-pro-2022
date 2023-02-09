using System.Threading.Tasks;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Supplier 
    /// </summary>
    public interface ISupplierRepository
    {
        Task<Supplier> AddAsync(Supplier supplier, string changeReason);

        Task<Supplier> UpdateAsync(Supplier supplier, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
