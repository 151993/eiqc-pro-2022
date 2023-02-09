using MediatR;
using System;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Add
{
    public class AddCommodityModel : BaseCommand, IRequest<CommodityModel>
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
