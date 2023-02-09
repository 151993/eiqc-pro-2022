using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Models;
using System;

namespace QSS.eIQC.Handlers.Commands.CommodityPartNumberSiteCommand
{
    public class CommodityPartNumberSiteModel : BaseStausModel<int>
    {
        public int CommodityId { get; set; }

        public string PartNumber { get; set; }

        public string SiteNo { get; set; }

        public virtual Commodity Commodity { get; set; }
        
    }
}
