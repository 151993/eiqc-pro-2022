using System;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPCommodityWithoutPart
    {

        public string SAPCommodityId { get; set; }

        public DateTimeOffset CommodityValidFrom { get; set; }

        public DateTimeOffset CommodityValidTo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
      
    }
}
