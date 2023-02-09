/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Delete
{
    /// <summary>
    /// Validator for Delete Severity operation
    /// </summary>
    public class DeletePCCodeCommandValidator : AbstractValidator<DeletePCCodeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public DeletePCCodeCommandValidator()
        {
            // Property validations
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
