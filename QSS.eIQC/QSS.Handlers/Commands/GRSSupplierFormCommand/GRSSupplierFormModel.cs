/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;
using QSS.eIQC.Handlers.Commands.GRSCommand;
using System;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand
{
    /// <summary>
    /// Representation model for GRSSupplierForm entity
    /// </summary>
    public class GRSSupplierFormModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set SupplierForm property
        /// </summary>        
        public SupplierFormModel SupplierForm { get; set; }



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set GRSNo property
        /// </summary>        
        public GRSModel GRS { get; set; }



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
        //public int? Status { get; set; }

    }
}
