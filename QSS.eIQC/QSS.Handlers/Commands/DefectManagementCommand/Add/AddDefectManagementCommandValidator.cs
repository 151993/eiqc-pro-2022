/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddDefectManagementCommandValidator : AbstractValidator<AddDefectManagementModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddDefectManagementCommandValidator()
        {
            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
