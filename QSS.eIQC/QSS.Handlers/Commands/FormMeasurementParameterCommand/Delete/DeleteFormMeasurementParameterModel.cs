/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormMeasurementParameter operation
    /// </summary>
    public class DeleteFormMeasurementParameterModel : IRequest<DeleteFormMeasurementParameterResponse>
    {
        /// <summary>
        /// FormMeasurementParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
