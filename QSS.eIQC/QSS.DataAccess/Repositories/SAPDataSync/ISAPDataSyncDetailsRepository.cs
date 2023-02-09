using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories.SAPDataSync
{
    public interface ISAPDataSyncDetailsRepository
    {
        Task<SAPDataSyncDetails> AddAsync(SAPDataSyncDetails syncSAPLastDate, string changeReason);

        Task<bool> IsSAPLastSyncDateExistsAsync(string name);
    }
}
