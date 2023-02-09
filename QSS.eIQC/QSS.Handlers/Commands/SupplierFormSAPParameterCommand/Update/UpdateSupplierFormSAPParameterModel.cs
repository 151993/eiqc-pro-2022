/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormSAPParameter operation
    /// </summary>
    public class UpdateSupplierFormSAPParameterModel : BaseUpdateCommand<int>, IRequest<SupplierFormSAPParameterModel>
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
        /// Get or set SAPParameterExpected property
        /// </summary>        
        public string SAPParameterExpected { get; set; }

        /// <summary>
        /// Get or set SAPParameterActual property
        /// </summary>        
        public string SAPParameterActual { get; set; }

    }
}
