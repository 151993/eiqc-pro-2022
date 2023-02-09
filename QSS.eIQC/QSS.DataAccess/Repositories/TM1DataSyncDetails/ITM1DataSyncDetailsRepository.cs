using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Division 
    /// </summary>
    public interface ITM1DataSyncDetailsRepository
    {
        Task<TM1DataSyncDetails> AddAsync(TM1DataSyncDetails syncTM1LastDate, string changeReason);
        Task<bool> IsTM1LastSyncDateExistsAsync(string name);
    }
}
