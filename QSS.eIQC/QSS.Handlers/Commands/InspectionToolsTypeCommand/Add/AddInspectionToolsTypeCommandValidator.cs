/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddInspectionToolsTypeCommandValidator : AbstractValidator<AddInspectionToolsTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddInspectionToolsTypeCommandValidator()
        {
           
            RuleFor(r => r.Type)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.AddedPcCodeIds).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
