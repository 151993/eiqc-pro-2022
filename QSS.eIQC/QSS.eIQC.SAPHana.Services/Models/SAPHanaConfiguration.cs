using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPHanaConfiguration
    {
        public string ConnString { get; set; }

        public string BaseUrl { get; set; }

        public string CommodityClassificationUrl { get; set; }

        public string PartNumberUrl { get; set; }

        public string SupplierAddressUrl { get; set; }

        public string PurchaseOrderUrl { get; set; }

        public string SampleSizeUrl { get; set; }        

        public string SamplingPlanUrl { get; set; }

        public int RefreshDay { get; set; }

        public int TopRecord { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string InputParameters { get; set; }

        public string SupplierInputParameters { get; set; }
    }
}
