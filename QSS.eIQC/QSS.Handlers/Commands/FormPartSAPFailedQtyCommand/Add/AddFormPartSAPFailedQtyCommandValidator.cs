/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormPartSAPFailedQtyCommandValidator : AbstractValidator<AddFormPartSAPFailedQtyModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormPartSAPFailedQtyCommandValidator()
        {
           

                RuleFor(r => r.GRSNo).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));


                RuleFor(r => r.PCCode).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));





            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
