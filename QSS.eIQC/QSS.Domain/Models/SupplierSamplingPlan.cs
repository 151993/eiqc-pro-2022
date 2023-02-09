/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierSamplingPlan entity model to map database SupplierSamplingPlan table 
    /// </summary>
    public class SupplierSamplingPlan : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierSamplingPlan()
        {
        }

        public int SMSId { get; set; }
        public int PartInspectionSamplingPlanId { get; set; }
        public virtual SupplierMeasurementSubmission SMS { get; set; }
        public virtual SAPPartInspectionPlanSamplingPlan PartInspectionSamplingPlan { get; set; }
        public int SampleSize { get; set; }
        public int FailedQuantity { get; set; }
    }
}
