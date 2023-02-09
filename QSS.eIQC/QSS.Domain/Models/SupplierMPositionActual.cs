/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierMPositionActual entity model to map database SupplierMPositionActual table 
    /// </summary>
    public class SupplierMPositionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierMPositionActual()
        {
        }
        public virtual SupplierMPosition SupplierMPosition { get; set; }
        public int SupplierMPositionId { get; set; }
        public string ActualText { get; set; }
        public string ActualValue { get; set; }
    }
}
