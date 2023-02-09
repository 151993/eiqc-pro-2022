using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class PartNumberBySiteModel
    {
        [Key]
        public string ID { get; set; }

        public string JABIL_PART_NO { get; set; }

        public string SITE { get; set; }

        public string MPN_MTRL_HERS { get; set; }

        public string MANUFACTURER { get; set; }

        public string PART_VALID_FROM { get; set; }

        public string PART_VALID_TO { get; set; }

        public string MEDIACODE { get; set; }

        public string MANUF_PART_NO { get; set; }

        public string MASKED_MPN { get; set; }

        public string MATERIAL_DESC { get; set; }

        public string JABIL_OWNER_CONTACT { get; set; }

        public string MATERIAL_GROUP { get; set; }

        public string CREATED_DATE { get; set; }

        public string LAST_MODIFIED_DATE { get; set; }

    }
}
