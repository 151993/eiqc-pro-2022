using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class SAPPartInspectionPlanSamplingPlan : PersistentObjectWithUpdate<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public string MstrChar { get; set; }

        public string SmplProc { get; set; }

        public string Site { get; set; }

        public string CertificateType { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }
    }
}
