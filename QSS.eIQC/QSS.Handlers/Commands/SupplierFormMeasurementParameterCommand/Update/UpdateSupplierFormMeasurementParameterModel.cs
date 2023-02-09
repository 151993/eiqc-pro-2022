/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormMeasurementParameter operation
    /// </summary>
    public class UpdateSupplierFormMeasurementParameterModel : BaseUpdateCommand<int>, IRequest<SupplierFormMeasurementParameterModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set ParameterName property
        /// </summary>        
        public string ParameterName { get; set; }

        /// <summary>
        /// Get or set InstrumentID property
        /// </summary>        
        public string InstrumentID { get; set; }

        /// <summary>
        /// Get or set InstrumentTypeID property
        /// </summary>        
        public string InstrumentTypeID { get; set; }

        /// <summary>
        /// Get or set UOM property
        /// </summary>        
        public string UOM { get; set; }

        /// <summary>
        /// Get or set NormalValue property
        /// </summary>        
        public double? NormalValue { get; set; }

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

    }
}
