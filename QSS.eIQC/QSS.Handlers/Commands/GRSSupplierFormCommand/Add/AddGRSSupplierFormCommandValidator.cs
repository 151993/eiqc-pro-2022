/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddGRSSupplierFormCommandValidator : AbstractValidator<AddGRSSupplierFormModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddGRSSupplierFormCommandValidator()
        {
           



                RuleFor(r => r.SupplierFormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);





                RuleFor(r => r.GRSNo).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));





                RuleFor(r => r.GRSNo).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.SubmitUser).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));







            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
