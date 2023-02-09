/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormPartSAPFailedQty entity model to map database FormPartSAPFailedQty table 
    /// </summary>
    public class FormPartSAPFailedQty : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormPartSAPFailedQty()
        {
        }

        [AuditLog]
        public string GRSNo { get; set; }
        [AuditLog]
        public string PCCode { get; set; }
        public int? FailedQty { get; set; }
    }
}
