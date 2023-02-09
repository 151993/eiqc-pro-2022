/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SAPPartInspectionPlan entity model to map database SAPPartInspectionPlan table 
    /// </summary>
    public class SAPPartInspectionPlanComment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public string Comments { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int SubmittedByUserId { get; set; }

        [ForeignKey("SubmittedByUserId")]
        public virtual User SubmittedByUser { get; set; }
    }
}
