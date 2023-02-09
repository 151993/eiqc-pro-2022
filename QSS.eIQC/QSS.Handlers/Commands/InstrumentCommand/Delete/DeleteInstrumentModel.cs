/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Instrument operation
    /// </summary>
    public class DeleteInstrumentModel : IRequest<DeleteInstrumentResponse>
    {
        /// <summary>
        /// Instrument Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
