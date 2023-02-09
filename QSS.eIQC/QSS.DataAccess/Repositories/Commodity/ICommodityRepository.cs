using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICommodityRepository
    {
        Task<Commodity> AddAsync(Commodity commodity, string changeReason);

        Task UpdateAsync(Commodity commodity, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

    }
}
