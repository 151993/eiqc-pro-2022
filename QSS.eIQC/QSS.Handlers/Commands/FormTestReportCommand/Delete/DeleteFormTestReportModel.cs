/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormTestReportCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormTestReport operation
    /// </summary>
    public class DeleteFormTestReportModel : IRequest<DeleteFormTestReportResponse>
    {
        /// <summary>
        /// FormTestReport Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
