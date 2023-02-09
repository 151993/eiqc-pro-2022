/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormStatusCommandValidator : AbstractValidator<AddFormStatusModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormStatusCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.StatusID).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.StatusID).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.UserName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.UserName).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.LastTime).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
