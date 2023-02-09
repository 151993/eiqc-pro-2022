/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormCountParameterCommandValidator : AbstractValidator<AddFormCountParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormCountParameterCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ParameterName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ParameterName).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));














                RuleFor(r => r.Remark).MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));


                RuleFor(r => r.InspectionDetails).MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));

           // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
