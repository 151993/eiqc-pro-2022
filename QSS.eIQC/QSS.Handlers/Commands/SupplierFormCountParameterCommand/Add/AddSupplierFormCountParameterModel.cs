/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddSupplierFormCountParameterModel : BaseCommand, IRequest<SupplierFormCountParameterModel>
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
        /// Get or set FailedQTYExpected property
        /// </summary>        
        public int? FailedQTYExpected { get; set; }
        /// <summary>
        /// Get or set FailedQTYActual property
        /// </summary>        
        public int? FailedQTYActual { get; set; }
        /// <summary>
        /// Get or set IToolsID property
        /// </summary>        
        public int? IToolsID { get; set; }
        /// <summary>
        /// Get or set Remark property
        /// </summary>        
        public string Remark { get; set; }
        /// <summary>
        /// Get or set InspectionDetails property
        /// </summary>        
        public string InspectionDetails { get; set; }
    }
}
