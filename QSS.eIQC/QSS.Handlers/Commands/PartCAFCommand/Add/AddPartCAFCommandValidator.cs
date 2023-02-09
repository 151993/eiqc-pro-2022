/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddPartCAFCommandValidator : AbstractValidator<AddPartCAFModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartCAFCommandValidator()
        {
           
            RuleFor(r => r.PartNo)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Hyperlink)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
