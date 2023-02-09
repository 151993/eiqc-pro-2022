/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormMeasurementParameterActual operation
    /// </summary>
    public class DeleteSupplierFormMeasurementParameterActualModel : IRequest<DeleteSupplierFormMeasurementParameterActualResponse>
    {
        /// <summary>
        /// SupplierFormMeasurementParameterActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
