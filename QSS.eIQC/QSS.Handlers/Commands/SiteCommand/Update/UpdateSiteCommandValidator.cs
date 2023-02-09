/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using QSS.eIQC.Handlers.Commands.SiteCommand.Update;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.EIQC.Handlers.Commands.SiteCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateSiteCommandValidator : AbstractValidator<UpdateSiteModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateSiteCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
             .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
