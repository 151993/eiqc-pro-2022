/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormMicroSectionCommandValidator : AbstractValidator<AddFormMicroSectionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormMicroSectionCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ParameterName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ParameterName).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));








                RuleFor(r => r.UOM).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));














                RuleFor(r => r.SampleSize).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
