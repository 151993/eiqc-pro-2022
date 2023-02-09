using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPSupplierModel
    {
        [Key]
        public string SAPSupplierModel_ID { get; set; }

        public string SITE_CODE { get; set; }

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

        public string SUPPLIER_STATUS { get; set; }

        public string SEARCH_TERM { get; set; }

        public string CHANGED_ON { get; set; }

        public string SITE_NAME { get; set; }
        public string VENDOR_NAME2 { get; set; }
        public string VENDOR_NAME3 { get; set; }
        public string VENDOR_NAME4 { get; set; }
        public string IC_SITE { get; set; }
        public string VENDOR_ACCT_GRP { get; set; }
        public string PURCHASE_ORG { get; set; }
        public string SALES_ORG_POC { get; set; }
        public string COMPANY_CODE { get; set; }
        public string VALUATION_AREA { get; set; }
        public string IC_VENDOR_OF_PLANT { get; set; }
        public string CREATED_DATE { get; set; }
        public string REGION { get; set; }
        public string LAND_CODE { get; set; }

    }
}