/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Update
{
    /// <summary>
    /// Representation model for Update DateCode operation
    /// </summary>
    public class UpdatePartDateCodeModel : BaseUpdateCommand<int>, IRequest<PartDateCodeModel>
    {
        public DateTimeOffset? ManufactureDate { get; set; }

        public int? ShelfLifeMonths { get; set; }

        public int? ManufactureDCWeeks { get; set; }

        public int? ManufactureDCYears { get; set; }

        public DateTimeOffset? SurfaceFinishingDate { get; set; }

        public string DateCodeDetails { get; set; }

        public DateTimeOffset? ExpireDate { get; set; }


    }
}
