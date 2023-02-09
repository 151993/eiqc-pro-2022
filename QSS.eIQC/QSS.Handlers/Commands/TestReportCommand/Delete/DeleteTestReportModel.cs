/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Delete
{
    /// <summary>
    /// Representation model for Delete TestReport operation
    /// </summary>
    public class DeleteTestReportModel : IRequest<DeleteTestReportResponse>
    {
        /// <summary>
        /// TestReport Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
