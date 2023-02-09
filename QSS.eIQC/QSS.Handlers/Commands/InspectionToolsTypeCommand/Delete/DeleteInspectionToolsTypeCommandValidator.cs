/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Delete
{
    /// <summary>
    /// Validator for Delete Severity operation
    /// </summary>
    public class DeleteInspectionToolsTypeCommandValidator : AbstractValidator<DeleteInspectionToolsTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public DeleteInspectionToolsTypeCommandValidator()
        {
            // Property validations
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
