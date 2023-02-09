/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete InstrumentType operation
    /// </summary>
    public class DeleteInstrumentTypeModel : IRequest<DeleteInstrumentTypeResponse>
    {
        /// <summary>
        /// InstrumentType Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
