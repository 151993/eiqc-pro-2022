using System;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands.PurchaseOrderCommand
{
    public class PurchaseOrderModel : BaseStausModel<int>
    {
        public string SAPPurchaseOrderId { get; set; }
        public string Site { get; set; }

        public string PART_NO { get; set; }

        public string VENDOR_CODE { get; set; }        

        public string PartNo { get; set; }

        public string MPNMaterial { get; set; }

        public string CreatedDate { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string PurchaseOrderLineNo { get; set; }

        public decimal Quantity { get; set; }

        public string VendorCode { get; set; }

        public string Manufacturer { get; set; }

        public string ManufacturerPartNo { get; set; }

        public string PurchaseOrderStatus { get; set; }

        public string Deleted { get; set; }

        public decimal QuantityDelivered { get; set; }

        public string LAST_MODIFIED_DATE { get; set; }

        public string LastModifiedDate { get; set; }

        public string PurchaseOrg { get; set; }

        public string PurchaseGroup { get; set; }

        public string CompanyCode { get; set; }

        public string DeliveryComplete { get; set; }
    }
}
