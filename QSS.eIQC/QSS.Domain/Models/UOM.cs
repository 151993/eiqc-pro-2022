/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// UOM entity model to map database UOM table 
    /// </summary>
    public class UOM : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        public UOM()
        {
           
            this.PartMPositionTolerances = new HashSet<PartMPositionTolerance>();
            this.PartLPositionTolerances = new HashSet<PartLPositionTolerance>();
            this.PartMeasurementParameters = new HashSet<PartMeasurementParameter>();
            this.PartFunParameters = new HashSet<PartFunParameter>();
            this.PartMicrosectionParameters = new HashSet<PartMicrosection>();

            this.SupplierMicrosectionParameters = new HashSet<SupplierMicrosection>();
            SupplierDimensionMeasurements = new HashSet<SupplierDimensionMeasurement>();
            SupplierFunctionVariables = new HashSet<SupplierFunctionVariable>();
        }

        [Unique]
        [AuditLog]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<PartMPositionTolerance> PartMPositionTolerances { get; set; }

        public virtual ICollection<PartLPositionTolerance> PartLPositionTolerances { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }

    }
}
