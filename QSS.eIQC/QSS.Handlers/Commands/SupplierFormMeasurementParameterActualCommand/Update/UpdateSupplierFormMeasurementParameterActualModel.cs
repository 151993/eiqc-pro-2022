/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormMeasurementParameterActual operation
    /// </summary>
    public class UpdateSupplierFormMeasurementParameterActualModel : BaseUpdateCommand<int>, IRequest<SupplierFormMeasurementParameterActualModel>
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
        /// Get or set No property
        /// </summary>        
        public int? No { get; set; }

        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double? ValueActual { get; set; }

    }
}
