/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormPartDateCodeCommandValidator : AbstractValidator<AddFormPartDateCodeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormPartDateCodeCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


                RuleFor(r => r.Requirement).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.SupplierDC).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.MFGDate).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.Result).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
