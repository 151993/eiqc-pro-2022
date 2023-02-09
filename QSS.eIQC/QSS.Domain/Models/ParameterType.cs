/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ParameterType entity model to map database ParameterType table 
    /// </summary>
    public class ParameterType : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string Code { get; set; }
        [AuditLog]
        public string Description { get; set; }
        [AuditLog]
        public string ComparationMethodDescription { get; set; }
   }
}
