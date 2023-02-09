/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormPartDateCode operation
    /// </summary>
    public class UpdateSupplierFormPartDateCodeModel : BaseUpdateCommand<int>, IRequest<SupplierFormPartDateCodeModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set Requirement property
        /// </summary>        
        public string Requirement { get; set; }

        /// <summary>
        /// Get or set SupplierDC property
        /// </summary>        
        public string SupplierDC { get; set; }

        /// <summary>
        /// Get or set MFGDate property
        /// </summary>        
        public string MFGDate { get; set; }

        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public string Result { get; set; }

   }
}
