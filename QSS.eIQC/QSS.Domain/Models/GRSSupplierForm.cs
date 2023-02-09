/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// GRSSupplierForm entity model to map database GRSSupplierForm table 
    /// </summary>
    public class GRSSupplierForm : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public GRSSupplierForm()
        {

        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }

        //[AuditLog(DisplayName = "Grs", ValueField = "GRSNo", MappingField = "GRSNo")]
        public virtual GRS GRS { get; set; }
        public string GRSNo { get; set; }
        [AuditLog]
        public string SubmitUser { get; set; }
        public DateTimeOffset? SubmitTime { get; set; }
   }
}
