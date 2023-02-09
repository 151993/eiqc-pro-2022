using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class SAPPartInspectionPlanSupplier : PersistentObjectWithUpdate<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

    }
}
