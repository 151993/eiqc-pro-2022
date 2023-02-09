/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormPartSAPFailedQtyRepository
    {
        Task<FormPartSAPFailedQty> AddAsync(FormPartSAPFailedQty formPartSAPFailedQty, string changeReason);

        Task UpdateAsync(FormPartSAPFailedQty formPartSAPFailedQty, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
