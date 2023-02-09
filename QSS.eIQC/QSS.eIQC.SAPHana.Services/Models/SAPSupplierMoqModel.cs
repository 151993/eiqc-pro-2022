using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPSupplierMoqModel
    {
        [Key]
        public string ID { get; set; }

        public string SITE_NAME { get; set; }

        public string EMAIL { get; set; }

        public string PHONE_NO { get; set; }

        public string FAX_NO { get; set; }

        public string VENDOR_CODE { get; set; }

        public string VENDOR_NAME { get; set; }

        public string ADDRESS_NO { get; set; }

        public string STREET_NO { get; set; }

        public string CITY { get; set; }

        public string POSTAL_CODE { get; set; }

        public string COUNTRY { get; set; }

        public string STATUS { get; set; }

        public string SEARCH_TERM { get; set; }

        public string CHANGED_ON { get; set; }
        
    }
}