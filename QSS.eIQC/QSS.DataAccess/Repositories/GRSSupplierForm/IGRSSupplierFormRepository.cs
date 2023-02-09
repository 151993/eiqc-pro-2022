/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IGRSSupplierFormRepository
    {
        Task<GRSSupplierForm> AddAsync(GRSSupplierForm gRSSupplierForm, string changeReason);

        Task UpdateAsync(GRSSupplierForm gRSSupplierForm, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
