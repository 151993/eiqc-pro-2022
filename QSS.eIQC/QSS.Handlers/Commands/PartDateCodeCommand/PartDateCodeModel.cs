/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand
{
    /// <summary>
    /// Representation model for DateCode entity
    /// </summary>
    public class PartDateCodeModel : BaseStausModel<int>
    {

        public DateTimeOffset? ManufactureDate { get; set; }

        public int? ShelfLifeMonths { get; set; }

        public int? ManufactureDCWeeks { get; set; }

        public int? ManufactureDCYears { get; set; }

        public DateTimeOffset? SurfaceFinishingDate { get; set; }

        public string DateCodeDetails { get; set; }

        public int? DateCodeLimit { get; set; }

        public DateTimeOffset? ExpireDate { get; set; }

    }
}
