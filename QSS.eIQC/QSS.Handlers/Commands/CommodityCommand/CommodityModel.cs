using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand;
using QSS.eIQC.Handlers.Commands.CommodityPartNumberSiteCommand;
using System;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand
{
    public class CommodityModel : BaseStausModel<int>
    {
        public string PART_NO { get; set; }
       
        public string SAPCommodityId { get; set; }

        public DateTimeOffset CommodityValidFrom { get; set; }

        public DateTimeOffset CommodityValidTo { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string AppearanceInspectionItem { get; set; }

        public string FunctionTestItem { get; set; }
        
        public int? CommodityCategoryOptionId { get; set; }

        public int? CommodityCategoryId { get; set; }

        public virtual CommodityCategoryModel CommodityCategory { get; set; }

        public virtual CommodityCategoryOptionModel CommodityCategoryOption { get; set; }

        public virtual CommodityPartNumberSiteModel CommodityPartNumberSite { get; set; }

        public string STATUS { get; set; }

        public string CHANGED_ON { get; set; }

        public string SiteNo { get; set; }
    }
}
