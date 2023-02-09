/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Add
{
    /// <summary>
    /// Representation model for Add FormPartDateCode operation
    /// </summary>
    public class AddFormPartDateCodeModel : BaseCommand, IRequest<FormPartDateCodeModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

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
