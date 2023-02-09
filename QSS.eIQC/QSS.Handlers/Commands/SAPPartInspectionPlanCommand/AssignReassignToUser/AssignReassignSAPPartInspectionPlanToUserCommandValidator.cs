/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Validator for Assign Reassign SAPPartInspectionPlan To User operation
    /// </summary>
    public class AssignReassignSAPPartInspectionPlanToUserCommandValidator : AbstractValidator<AssignReassignSAPPartInspectionPlanToUserModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AssignReassignSAPPartInspectionPlanToUserCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.AssignToUserId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            .NotEqual(0).WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
