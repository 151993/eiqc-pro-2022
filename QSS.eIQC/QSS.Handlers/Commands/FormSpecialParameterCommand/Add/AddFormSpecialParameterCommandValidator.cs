/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormSpecialParameterCommandValidator : AbstractValidator<AddFormSpecialParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormSpecialParameterCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ParameterName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ParameterName).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


                RuleFor(r => r.ResultDesc).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));




            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
