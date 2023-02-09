/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormResultOrientedParameterCommandValidator : AbstractValidator<AddFormResultOrientedParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormResultOrientedParameterCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ParameterName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ParameterName).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));

                RuleFor(r => r.ResultExpected).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);





                RuleFor(r => r.TestCondition).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));


                RuleFor(r => r.InspectionDetails).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
