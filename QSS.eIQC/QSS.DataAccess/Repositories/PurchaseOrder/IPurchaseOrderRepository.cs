using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPurchaseOrderRepository
    {
        Task<PurchaseOrder> AddAsync(PurchaseOrder commodity, string changeReason);

        Task UpdateAsync(PurchaseOrder commodity, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

    }
}
