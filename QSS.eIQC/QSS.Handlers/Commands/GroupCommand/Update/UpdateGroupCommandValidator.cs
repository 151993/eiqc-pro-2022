/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateGroupCommandValidator : AbstractValidator<UpdateGroupModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateGroupCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.WareHouse)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.UserName)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
