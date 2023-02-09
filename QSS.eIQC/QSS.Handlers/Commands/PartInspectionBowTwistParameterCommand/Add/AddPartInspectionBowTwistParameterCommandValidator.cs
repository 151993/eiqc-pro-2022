/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddPartInspectionBowTwistParameterCommandValidator : AbstractValidator<AddPartInspectionBowTwistParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartInspectionBowTwistParameterCommandValidator()
        {

          RuleFor(r => r.Unit).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));

          RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
