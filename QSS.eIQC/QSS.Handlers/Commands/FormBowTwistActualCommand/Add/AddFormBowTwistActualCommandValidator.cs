/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormBowTwistActualCommandValidator : AbstractValidator<AddFormBowTwistActualModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormBowTwistActualCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ParameterName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ParameterName).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

                RuleFor(r => r.SAPParameterExpected).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.SAPParameterExpected).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.SAPParameterActual).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.SAPParameterActual).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
