/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormMicroSectionActual operation
    /// </summary>
    public class UpdateSupplierFormMicroSectionActualModel : BaseUpdateCommand<int>, IRequest<SupplierFormMicroSectionActualModel>
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
        public int No { get; set; }

        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double ValueActual { get; set; }

    }
}
