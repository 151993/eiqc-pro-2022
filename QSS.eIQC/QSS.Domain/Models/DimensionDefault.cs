/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// DimensionDefault entity model to map database DimensionDefault table 
    /// </summary>
    public class DimensionDefault : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public DimensionDefault()
        {

        }
        public string DimensionName { get; set; }

    }
}
