/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using System;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand
{
    /// <summary>
    /// Representation model for Instrument entity
    /// </summary>
    public class InstrumentModel : BaseStausModel<int>
    {
        public string InstrumentNo { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ValidDate { get; set; }
        public int InstrumentTypeId { get; set; }

        public InstrumentTypeModel InstrumentType { get; set; }
    }
}
