/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormLPosition operation
    /// </summary>
    public class UpdateSupplierFormLPositionModel : BaseUpdateCommand<int>, IRequest<SupplierFormLPositionModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set LineNo property
        /// </summary>        
        public string LineNo { get; set; }

        /// <summary>
        /// Get or set ITCode property
        /// </summary>        
        public string ITCode { get; set; }

        /// <summary>
        /// Get or set UOM property
        /// </summary>        
        public string UOM { get; set; }

        /// <summary>
        /// Get or set Spec property
        /// </summary>        
        public double? Spec { get; set; }

        /// <summary>
        /// Get or set UpperLimit property
        /// </summary>        
        public double UpperLimit { get; set; }

        /// <summary>
        /// Get or set LowerLimit property
        /// </summary>        
        public double LowerLimit { get; set; }

        /// <summary>
        /// Get or set Accuracy property
        /// </summary>        
        public int? Accuracy { get; set; }

        /// <summary>
        /// Get or set SampleSize property
        /// </summary>        
        public string SampleSize { get; set; }

        /// <summary>
        /// Get or set UpperLimit1 property
        /// </summary>        
        public double? UpperLimit1 { get; set; }

        /// <summary>
        /// Get or set LowerLimit1 property
        /// </summary>        
        public double? LowerLimit1 { get; set; }

        /// <summary>
        /// Get or set ITCode1 property
        /// </summary>        
        public string ITCode1 { get; set; }

        /// <summary>
        /// Get or set UpperLimit2 property
        /// </summary>        
        public double? UpperLimit2 { get; set; }

        /// <summary>
        /// Get or set LowerLimit2 property
        /// </summary>        
        public double? LowerLimit2 { get; set; }

        /// <summary>
        /// Get or set ITCode2 property
        /// </summary>        
        public string ITCode2 { get; set; }

        /// <summary>
        /// Get or set UpperLimit3 property
        /// </summary>        
        public double? UpperLimit3 { get; set; }

        /// <summary>
        /// Get or set LowerLimit3 property
        /// </summary>        
        public double? LowerLimit3 { get; set; }

        /// <summary>
        /// Get or set ITCode3 property
        /// </summary>        
        public string ITCode3 { get; set; }

        /// <summary>
        /// Get or set PositionType property
        /// </summary>        
        public int? PositionType { get; set; }

    }
}
