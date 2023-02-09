using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierLPositionActual entity model to map database SupplierLPositionActual table 
    /// </summary>
    public class SupplierLPositionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierLPositionActual()
        {
        }
        public virtual SupplierLPosition SupplierLPosition { get; set; }
        public int SupplierLPositionId { get; set; }
        public string ActualText { get; set; }
        public string ActualValue { get; set; }
    }
}