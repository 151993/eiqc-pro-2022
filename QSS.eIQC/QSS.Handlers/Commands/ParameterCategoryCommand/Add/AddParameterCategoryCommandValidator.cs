/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddParameterCategoryCommandValidator : AbstractValidator<AddParameterCategoryModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddParameterCategoryCommandValidator()
        {
           







                RuleFor(r => r.Description).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));







           // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
