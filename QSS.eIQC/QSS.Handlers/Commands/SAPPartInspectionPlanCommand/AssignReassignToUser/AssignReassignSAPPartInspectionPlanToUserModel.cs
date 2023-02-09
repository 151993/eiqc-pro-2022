/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Representation model for AssignReassign SAPPartInspectionPlan to User operation
    /// </summary>
    public class AssignReassignSAPPartInspectionPlanToUserModel : BaseUpdateCommand<int>, IRequest<SAPPartInspectionPlanModel>
    {
        public int AssignToUserId { get; set; }
    }
}
