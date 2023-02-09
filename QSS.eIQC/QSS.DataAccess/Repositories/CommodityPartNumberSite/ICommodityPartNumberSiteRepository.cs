using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICommodityPartNumberSiteRepository
    {
        Task<CommodityPartNumberSite> AddAsync(CommodityPartNumberSite commodity, string changeReason);

        Task UpdateAsync(CommodityPartNumberSite commodity, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

    }
}
