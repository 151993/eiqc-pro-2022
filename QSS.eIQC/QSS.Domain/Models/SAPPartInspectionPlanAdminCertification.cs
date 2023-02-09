using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class SAPPartInspectionPlanAdminCertification : PersistentObjectWithUpdate<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public int? AdminCertificationId { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual AdminCertification AdminCertification { get; set; }

    }
}
