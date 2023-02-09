/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateFormTypeCommandValidator : AbstractValidator<UpdateFormTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateFormTypeCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

                RuleFor(r => r.FormTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.Type).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Type).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
