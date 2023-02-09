/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddCompletedGRSCommandValidator : AbstractValidator<AddCompletedGRSModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddCompletedGRSCommandValidator()
        {

            RuleFor(r => r.PartNo)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.UDCode)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.GRSNo)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
