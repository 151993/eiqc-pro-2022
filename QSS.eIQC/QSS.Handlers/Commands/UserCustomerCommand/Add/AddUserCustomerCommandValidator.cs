/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddUserCustomerCommandValidator : AbstractValidator<AddUserCustomerModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddUserCustomerCommandValidator()
        {
            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
