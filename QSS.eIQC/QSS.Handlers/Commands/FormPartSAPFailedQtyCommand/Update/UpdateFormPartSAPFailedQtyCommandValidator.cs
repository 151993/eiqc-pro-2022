/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateFormPartSAPFailedQtyCommandValidator : AbstractValidator<UpdateFormPartSAPFailedQtyModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateFormPartSAPFailedQtyCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);


                RuleFor(r => r.GRSNo).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));


                RuleFor(r => r.PCCode).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));




            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
