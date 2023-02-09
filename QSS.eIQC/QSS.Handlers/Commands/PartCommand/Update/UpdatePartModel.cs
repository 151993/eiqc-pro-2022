/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartCommand.Update
{
    /// <summary>
    /// Representation model for Update Part operation
    /// </summary>
    public class UpdatePartModel : BaseUpdateCommand<int>, IRequest<PartModel>
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
