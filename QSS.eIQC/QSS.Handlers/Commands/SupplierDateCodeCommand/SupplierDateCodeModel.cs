/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierDateCodeCommand
{
    /// <summary>
    /// Representation model for DateCode entity
    /// </summary>
    public class SupplierDateCodeModel : BaseStausModel<int>
    {

        public DateTimeOffset? ManufactureDate { get; set; }

        public int? ManufactureDCWeeks { get; set; }

        public int? ManufactureDCYears { get; set; }

        public DateTimeOffset? SurfaceFinishingDate { get; set; }

        public int? RemainingDays { get; set; }

        public int? AcceptRejectId { get; set; }

        public int? ShelfLifeMonths { get; set; }

        public string DateCodeDetails { get; set; }

        public DateTimeOffset? ExpireDate { get; set; }

    }
}
