
﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete ParameterTypeCode operation
    /// </summary>
    public class DeleteParameterTypeCodeModel : IRequest<DeleteParameterTypeCodeResponse>
    {
        /// <summary>
        /// ParameterTypeCode Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
