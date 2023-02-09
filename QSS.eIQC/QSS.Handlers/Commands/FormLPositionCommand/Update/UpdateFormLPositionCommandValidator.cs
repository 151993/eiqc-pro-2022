/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormLPositionCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateFormLPositionCommandValidator : AbstractValidator<UpdateFormLPositionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateFormLPositionCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);




                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.LineNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.LineNo).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.ITCode).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ITCode).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.UOM).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.UOM).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));




                RuleFor(r => r.UpperLimit).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.LowerLimit).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);





                RuleFor(r => r.SampleSize).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));








                RuleFor(r => r.ITCode1).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));








                RuleFor(r => r.ITCode2).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));








                RuleFor(r => r.ITCode3).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));





            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
