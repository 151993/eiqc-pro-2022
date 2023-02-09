/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierMPositionActualRepository
    {
        void AddSupplierMPositionActuals(SupplierMPosition supplierMPosition, IEnumerable<SupplierMPositionActual> supplierMPositionActuals);

        void RemoveRange(SupplierMPosition supplierMPosition);
    }
}
