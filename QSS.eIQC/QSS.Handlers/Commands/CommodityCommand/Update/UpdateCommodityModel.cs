using MediatR;
using System;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Update
{
    public class UpdateCommodityModel : BaseUpdateCommand<int>, IRequest<CommodityModel>
    {
        public string SAPCommodityId { get; set; }

        public DateTimeOffset CommodityValidFrom { get; set; }

        public DateTimeOffset CommodityValidTo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string AppearanceInspectionItem { get; set; }

        public string FunctionTestItem { get; set; }

        public int? CommodityCategoryOptionId { get; set; }

        public int? CommodityCategoryId { get; set; }
    }
}
