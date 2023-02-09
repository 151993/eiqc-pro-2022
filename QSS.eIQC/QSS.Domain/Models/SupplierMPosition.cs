/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierMPosition entity model to map database SupplierMPosition table 
    /// </summary>
    public class SupplierMPosition : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierMPosition()
        {
            this.SupplierMPositionActuals = new HashSet<SupplierMPositionActual>();
        }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }
        public int SupplierMeasurementSubmissionId { get; set; }
        public virtual PartMPositionTolerance PartMPositionTolerance { get; set; }
        public int? PartMPositionToleranceId { get; set; }
        public virtual ParameterManagement ParameterManagement { get; set; }
        public int? ParameterManagementId { get; set; }
        public virtual PartDimension PartDimension { get; set; }
        public int? PartDimensionId { get; set; }
        public virtual DimensionDefault DimensionDefault { get; set; }
        public int? DimensionDefaultId { get; set; }
        public int? AssociatedDimensionNumberId { get; set; }
        public virtual UOM UOM { get; set; }
        public int? UOMId { get; set; }
        public virtual Instrument Instrument { get; set; }
        public int? InstrumentId { get; set; }
        public virtual InstrumentType InstrumentType { get; set; }
        public int? InstrumentTypeId { get; set; }

        public virtual ICollection<SupplierMPositionActual> SupplierMPositionActuals { get; set; }
    }
}
