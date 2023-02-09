/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierAttachmentRepository
    {
        Task<SupplierAttachment> AddAsync(SupplierAttachment supplierAttachment, string changeReason);

        Task UpdateAsync(SupplierAttachment supplierAttachment, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
