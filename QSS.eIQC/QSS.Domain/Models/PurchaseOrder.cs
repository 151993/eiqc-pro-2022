using QSS.eIQC.Domain.EnumModels;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class PurchaseOrder : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PurchaseOrder()
        {

        }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public string SAPPurchaseOrderId { get; set; }

        public string Site { get; set; }

        public string PartNo { get; set; }

        public string MPNMaterial { get; set; }

        public string CreatedDate { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string PurchaseOrderLineNo { get; set; }

        public decimal? Quantity { get; set; }

        public string VendorCode { get; set; }

        public string Manufacturer { get; set; }

        public string ManufacturerPartNo { get; set; }

        public string PurchaseOrderStatus { get; set; }

        public string Deleted { get; set; }

        public decimal? QuantityDelivered { get; set; }

        public string LastModifiedDate { get; set; }

        public string PurchaseOrg { get; set; }

        public string PurchaseGroup { get; set; }

        public string CompanyCode { get; set; }

        public string DeliveryComplete { get; set; }

    }
}
