/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddCommodityCategoryCommandValidator : AbstractValidator<AddCommodityCategoryModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddCommodityCategoryCommandValidator()
        {
           
                RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

               // RuleFor(r => r.CommodityCategoryTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


                RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
