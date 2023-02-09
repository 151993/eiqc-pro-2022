using System;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPPurchaseOrderModel
    {
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        /// 
        [Key]
        public string PurchaseOrderId { get; set; }

        //public string ID { get; set; }

        public string SITE { get; set; }

        public string PART_NO { get; set; }

        public string MPN_MATERIAL { get; set; }

        public string CREATED_DATE { get; set; }

        public string PO_NO { get; set; }

        public string PO_LINE_NO { get; set; }

        public decimal? QUANTITY { get; set; }

        public string VENDOR_CODE { get; set; }

        public string MANUFACTURER { get; set; }

        public string MANUF_PART_NO { get; set; }

        public string PO_STATUS { get; set; }

        public string DELETED { get; set; }

        public decimal? QTY_DELIVERED { get; set; }

        public string LAST_MODIFIED_DATE { get; set; }

        public string PURCHASE_ORG { get; set; }

        public string PURCHASE_GROUP { get; set; }

        public string COMPANY_CODE { get; set; }

        public string DELIVERY_COMPLETE { get; set; }


    }
}
