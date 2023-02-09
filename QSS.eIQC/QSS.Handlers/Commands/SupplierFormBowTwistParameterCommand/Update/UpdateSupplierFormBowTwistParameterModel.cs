/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormBowTwistParameter operation
    /// </summary>
    public class UpdateSupplierFormBowTwistParameterModel : BaseUpdateCommand<int>, IRequest<SupplierFormBowTwistParameterModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set WarpType property
        /// </summary>        
        public int? WarpType { get; set; }

        /// <summary>
        /// Get or set Spec property
        /// </summary>        
        public string Spec { get; set; }

        /// <summary>
        /// Get or set Length property
        /// </summary>        
        public string Length { get; set; }

        /// <summary>
        /// Get or set Width property
        /// </summary>        
        public string Width { get; set; }

        /// <summary>
        /// Get or set Unit property
        /// </summary>        
        public string Unit { get; set; }

        /// <summary>
        /// Get or set UpperLimit property
        /// </summary>        
        public string UpperLimit { get; set; }

    }
}
