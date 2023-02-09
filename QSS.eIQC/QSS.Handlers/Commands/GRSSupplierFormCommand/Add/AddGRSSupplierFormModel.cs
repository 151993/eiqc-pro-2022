/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Add
{
    /// <summary>
    /// Representation model for Add GRSSupplierForm operation
    /// </summary>
    public class AddGRSSupplierFormModel : BaseCommand, IRequest<GRSSupplierFormModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }




        /// <summary>
        /// Get or set GRSNo property
        /// </summary>        
        public string GRSNo { get; set; }

        /// <summary>
        /// Get or set SubmitUser property
        /// </summary>        
        public string SubmitUser { get; set; }

        /// <summary>
        /// Get or set SubmitTime property
        /// </summary>        
        public DateTimeOffset? SubmitTime { get; set; }

        /// <summary>
        /// Get or set Status property
        /// </summary>        
        public int? Status { get; set; }

   }
}
