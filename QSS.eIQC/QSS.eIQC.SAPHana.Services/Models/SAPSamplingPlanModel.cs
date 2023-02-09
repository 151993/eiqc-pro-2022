
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPSamplingPlanModel
    {
        [Key]    

        public string ID { get; set; }

        public string PART_NO { get; set; }

        public string SITE { get; set; }

        public string MATERIAL_GROUP { get; set; }

        public string TASK_LIST_TYPE { get; set; }

        public string GROUP { get; set; }

        public string GRP_CTR { get; set; }

        public string COUNTER { get; set; }

        public string TASK_LIST_NODE { get; set; }

        public string BASE_QTY { get; set; }

        public string CHAR_TYPE { get; set; }

        public string INSP_CHAR { get; set; }

        public string SMPL_PROC { get; set; }

        public string VERSION { get; set; }

        public string MSTRCHAR { get; set; }

        public string QM_CTRL_KEY { get; set; }

        public string CERT_TYPE { get; set; }

        public string INSP_SETUP { get; set; }

        public string QM_ACTIVE { get; set; }

        public string INSP_SHORT_TEXT { get; set; }

        public string CREATED_ON { get; set; }

        public string VALID_DATE { get; set; }

        public string DELETE_IND { get; set; }

        public string INACTIVE { get; set; }
    }
}
