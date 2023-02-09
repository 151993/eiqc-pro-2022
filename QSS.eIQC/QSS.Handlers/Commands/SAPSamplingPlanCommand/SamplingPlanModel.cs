/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands.SAPSamplingPlanCommand
{
    /// <summary>
    /// Representation model for SAPPartInspectionPlan entity
    /// </summary>
    public class SamplingPlanModel 
    {
        [Key]
        public string SamplingPlanId { get; set; }

        public string PartNo { get; set; }
        public string PART_NO { get; set; }

        public string Site { get; set; }

        public string MaterialGroup { get; set; }

        public string TaskListType { get; set; }

        public string Group { get; set; }

        public string GrpCtr { get; set; }

        public string Counter { get; set; }

        public string TaskListNode { get; set; }

        public string BaseQty { get; set; }

        public string CharType { get; set; }

        public string InspChar { get; set; }

        public string SmplProc { get; set; }

        public string Version { get; set; }

        public string MstrChar { get; set; }

        public string QmCtrlKey { get; set; }

        public string CertType { get; set; }

        public string InspSetUp { get; set; }

        public string QmActive { get; set; }

        public string InspShortText { get; set; }

        public string CreatedOn { get; set; }

        public string ValidDate { get; set; }

        public string DeleteInd { get; set; }

        public string InActive { get; set; }

        public bool IsEnabled { get; set; } = true;
    }
}