/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand
{
    /// <summary>
    /// Representation model for PartInspectionSpecification entity
    /// </summary>
    public class PartInspectionSpecificationModel : BaseStausModel<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public string SpecRevisionNumber { get; set; }

        public string SpecNumber { get; set; }

        public string SpecDescription { get; set; }

        public int? SubmittedByUserId { get; set; }

        public virtual UserModel SubmittedBy { get; set; }

        public virtual IEnumerable<PartInspectionSpecAttachmentModel> PartInspectionSpecAttachments { get; set; }

        public List<int> RemovedSpecAttachmentIds { get; set; }

        public virtual IEnumerable<AttachmentModel> SpecAttachments { get; set; }

    }
}
