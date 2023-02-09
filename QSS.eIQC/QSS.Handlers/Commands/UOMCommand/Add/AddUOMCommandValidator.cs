/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddUOMCommandValidator : AbstractValidator<AddUOMModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddUOMCommandValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));
            RuleFor(r => r.Description)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
