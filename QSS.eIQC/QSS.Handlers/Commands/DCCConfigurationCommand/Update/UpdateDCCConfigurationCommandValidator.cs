/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateDCCConfigurationCommandValidator : AbstractValidator<UpdateDCCConfigurationModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateDCCConfigurationCommandValidator()
        {
                RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);
                RuleFor(r => r.SiteNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.SiteNo).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));
                RuleFor(r => r.DeptCode).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));
                RuleFor(r => r.DocLevel).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));
                RuleFor(r => r.SiteId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
               .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
