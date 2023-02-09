/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartCommand.Add
{
    /// <summary>
    /// Representation model for Add Part operation
    /// </summary>
    public class AddPartModel : BaseCommand, IRequest<PartModel>
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
