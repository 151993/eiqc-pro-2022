/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IAdminCertificationRepository
    {
        Task<AdminCertification> AddAsync(AdminCertification adminCertification, string changeReason);

        Task UpdateAsync(AdminCertification adminCertification, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
