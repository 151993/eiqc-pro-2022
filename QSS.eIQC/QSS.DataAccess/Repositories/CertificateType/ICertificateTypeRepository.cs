/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICertificateTypeRepository
    {
        Task<CertificateType> AddAsync(CertificateType certificateType, string changeReason);

        Task<CertificateType> UpdateAsync(CertificateType certificateType, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
