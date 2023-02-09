/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateAdminCertificationCommandValidator : AbstractValidator<UpdateAdminCertificationModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateAdminCertificationCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

             

                RuleFor(r => r.Number).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Number).MaximumLength(15).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(15));

                RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.Description).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Description).MaximumLength(150).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(150));

                RuleFor(r => r.AssessmentBodyId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.AssessmentBodyId).MaximumLength(15).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(15));

                RuleFor(r => r.AssessmentBodyName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.AssessmentBodyName).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.CertificateStartDate).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.CertificateEndDate).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
