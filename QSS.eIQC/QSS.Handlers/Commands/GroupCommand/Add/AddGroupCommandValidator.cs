/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddGroupCommandValidator : AbstractValidator<AddGroupModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddGroupCommandValidator()
        {
           
            RuleFor(r => r.WareHouse)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.UserName)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
