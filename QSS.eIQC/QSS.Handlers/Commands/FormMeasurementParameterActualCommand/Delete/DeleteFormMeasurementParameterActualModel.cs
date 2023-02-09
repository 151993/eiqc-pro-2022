/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormMeasurementParameterActual operation
    /// </summary>
    public class DeleteFormMeasurementParameterActualModel : IRequest<DeleteFormMeasurementParameterActualResponse>
    {
        /// <summary>
        /// FormMeasurementParameterActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}