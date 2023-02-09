using QSS.eIQC.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPPartModel
    {
        [Key]
        public string Id { get; set; }

        public string PartNo { get; set; }

        public string Site { get; set; }

        public string PartDescription { get; set; }

        public string MPNMaterialHers { get; set; }     

        public string Manufacturer { get; set; }

        public string PartValidFrom { get; set; }

        public string PartValidTo { get; set; }

        public string MediaCode { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string MaskedMPN { get; set; }

        public string JabilOwnerContact { get; set; }

        public string MaterialGroup { get; set; }      
        
        public string Commodity { get; set; }

        public string CreatedDate { get; set; }

        public string LastModifiedDate { get; set; }

        public bool IsEnabled { get; set; }

    }
}