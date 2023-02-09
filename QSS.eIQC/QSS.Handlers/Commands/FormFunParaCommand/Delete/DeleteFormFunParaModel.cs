/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormFunParaCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormFunPara operation
    /// </summary>
    public class DeleteFormFunParaModel : IRequest<DeleteFormFunParaResponse>
    {
        /// <summary>
        /// FormFunPara Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
