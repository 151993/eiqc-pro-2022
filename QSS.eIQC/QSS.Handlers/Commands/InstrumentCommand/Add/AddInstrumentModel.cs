/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand.Add
{
    /// <summary>
    /// Representation model for Add Instrument operation
    /// </summary>
    public class AddInstrumentModel : BaseCommand, IRequest<InstrumentModel>
    {
        public string InstrumentNo { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ValidDate { get; set; }
        public int InstrumentTypeId { get; set; }
    }
}
