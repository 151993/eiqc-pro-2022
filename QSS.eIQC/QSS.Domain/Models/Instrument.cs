/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Instrument entity model to map database Instrument table 
    /// </summary>
    public class Instrument : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Instrument()
        {
            SupplierMicrosectionParameters = new HashSet<SupplierMicrosection>();
            SupplierDimensionMeasurements = new HashSet<SupplierDimensionMeasurement>();
            SupplierFunctionVariables = new HashSet<SupplierFunctionVariable>();
        }

        [AuditLog]
        [Unique]
        public string InstrumentNo { get; set; }
        [AuditLog]
        public string Description { get; set; }
        public DateTimeOffset ValidDate { get; set; }
        public int InstrumentTypeId { get; set; }

        [AuditLog(DisplayName = "InstrumentType", ValueField = "Code", MappingField = "InstrumentTypeId")]
        public virtual InstrumentType InstrumentType { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }


    }
}
