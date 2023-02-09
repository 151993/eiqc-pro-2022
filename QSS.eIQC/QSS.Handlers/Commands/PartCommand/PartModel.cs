
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartCommand
{
    /// <summary>
    /// Representation model for Part entity
    /// </summary>
    public class PartModel : BaseStausModel<int>
    {
        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string Site { get; set; }

        public string Commodity { get; set; }

        public string MPNMaterial { get; set; }

        public string Mediacode { get; set; }

        public string MaskedMPN { get; set; }

        public string Manufacturer { get; set; }

        public string Vendor { get; set; }

    }
}
