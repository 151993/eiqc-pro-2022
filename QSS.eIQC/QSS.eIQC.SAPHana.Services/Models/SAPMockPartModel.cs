using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPMockPartModel
    {
        [Key]
        public string Id { get; set; }

        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string Site { get; set; }

        public string Commodity { get; set; }

        public string MPNMaterial { get; set; }

        public string Mediacode { get; set; }

        public string MaskedMPN { get; set; }

        public string Manufacturer { get; set; }

        public string Vendor { get; set; }

        public bool IsEnabled { get; set; }

        public string SupplierName { get; set; }

        public string SupplierPhoneNumber { get; set; }

        public string SupplierEmail { get; set; }

        public string JabilOwnerContact { get; set; }

        public bool Deleted { get; set; }

        public ICollection<SAPSamplingPlan> samplingPlans { get; set; }

        public ICollection<SAPManufacturePartNumber> PartManufacturePartNumbers { get; set; }

    }
}