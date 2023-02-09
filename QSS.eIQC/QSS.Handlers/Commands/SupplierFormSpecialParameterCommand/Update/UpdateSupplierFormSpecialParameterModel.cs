/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormSpecialParameter operation
    /// </summary>
    public class UpdateSupplierFormSpecialParameterModel : BaseUpdateCommand<int>, IRequest<SupplierFormSpecialParameterModel>
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
        /// Get or set ResultDesc property
        /// </summary>        
        public string ResultDesc { get; set; }

        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public bool Result { get; set; }

    }
}
