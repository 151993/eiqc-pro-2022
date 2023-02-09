/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddSupplierFormBowTwistActualModel : BaseCommand, IRequest<SupplierFormBowTwistActualModel>
    {
        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }
        /// <summary>
        /// Get or set WarpType property
        /// </summary>        
        public int WarpType { get; set; }
        /// <summary>
        /// Get or set No property
        /// </summary>        
        public int No { get; set; }
        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double? ValueActual { get; set; }
    }
}
