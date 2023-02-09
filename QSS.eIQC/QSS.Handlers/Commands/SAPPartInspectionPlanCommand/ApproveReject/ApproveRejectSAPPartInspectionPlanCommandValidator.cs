/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class ApproveRejectSAPPartInspectionPlanCommandValidator : AbstractValidator<ApproveRejectSAPPartInspectionPlanModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public ApproveRejectSAPPartInspectionPlanCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.IP).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.DivisionModelNumber).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.GenWI).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.RefDoc).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            //RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
