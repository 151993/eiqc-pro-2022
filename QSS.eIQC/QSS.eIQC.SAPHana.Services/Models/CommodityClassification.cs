using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class CommodityClassification
    {
        [Key]
        public string COMMODITY_CLASSIFICATION_ID { get; set; }
        public string PART_NO { get; set; }
        public string SITE_NO { get; set; }
        public string COMMODITY_ID { get; set; }
        public string COMMODITY_NAME { get; set; }
        public string COMMODITY_DESC { get; set; }
        public string VALID_FROM { get; set; }
        public string VALID_TO { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_ON { get; set; }
        public string CHANGED_ON { get; set; }
        public string STATUS { get; set; }
    }
}
