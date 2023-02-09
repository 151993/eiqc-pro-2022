/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IBuyerRepository
    {
        Task<Buyer> AddAsync(Buyer buyer, string changeReason);

        Task UpdateAsync(Buyer buyer, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
