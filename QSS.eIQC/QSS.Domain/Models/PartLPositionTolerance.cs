/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartLPositionTolerance entity model to map database PartLPositionTolerance table 
    /// </summary>
    public class PartLPositionTolerance : PersistentObjectWithUpdate<int>
    {
        public PartLPositionTolerance()
        {
        }
        public double? SpecLimitAtMMC { get; set; }

        public double? SpecLimitAtLMC { get; set; }

        public double? Spec { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }

        public int PartDimensionId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int DataTypeId { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual PartDimension PartDimension { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual UOM UOM { get; set; }

        public virtual InstrumentType InstrumentType { get; set; }

        public virtual DataTypeModel DataType { get; set; }
    }
}
