/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.RosettaCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddRosettaCommandValidator : AbstractValidator<AddRosettaModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddRosettaCommandValidator()
        {
           
            RuleFor(r => r.EN_US)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.ZH_CN)
                .MaximumLength(150).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(150));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
