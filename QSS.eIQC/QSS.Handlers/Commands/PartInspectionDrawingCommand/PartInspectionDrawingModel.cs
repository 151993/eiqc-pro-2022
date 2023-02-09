/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand
{
    /// <summary>
    /// Representation model for PartCountParameter entity
    /// </summary>
    public class PartInspectionDrawingModel : BaseStausModel<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public string DrawingNumber { get; set; }

        public string DrawingRevisionNumber { get; set; }

        public string DrawingDescription { get; set; }

        public int? SubmittedByUserId { get; set; }

        public virtual UserModel SubmittedBy { get; set; }

        public virtual IEnumerable<PartInspectionDrawingAttachmentModel> PartInspectionDrawingAttachments { get; set; }

        public List<int> RemovedDrawingAttachmentIds { get; set; }

        public virtual IEnumerable<AttachmentModel> DrawingAttachments { get; set; }

    }
}
