/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand
{
    /// <summary>
    /// Representation model for SAPPartInspectionPlanComments entity
    /// </summary>
    public class SAPPartInspectionPlanCommentModel : BaseStausModel<int>
    {
        public string Comments { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int SubmittedByUserId { get; set; }

        public virtual UserModel SubmittedByUser { get; set; }
    }
}
