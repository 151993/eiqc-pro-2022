/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateFormBowTwistParameterCommandValidator : AbstractValidator<UpdateFormBowTwistParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateFormBowTwistParameterCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);




                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);





                RuleFor(r => r.Spec).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.Length).MaximumLength(53).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(53));


                RuleFor(r => r.Width).MaximumLength(53).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(53));


                RuleFor(r => r.Unit).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));


                RuleFor(r => r.UpperLimit).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
