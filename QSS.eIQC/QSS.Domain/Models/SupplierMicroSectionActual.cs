/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierMicroSectionActual entity model to map database SupplierMicroSectionActual table 
    /// </summary>
    public class SupplierMicroSectionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierMicroSectionActual()
        {
        }
        public virtual SupplierMicrosection SupplierMicrosection { get; set; }
        public int SupplierMicrosectionId { get; set; }
        public string ActualTextName { get; set; }
        public string ActualTextValue { get; set; }
    }
}
