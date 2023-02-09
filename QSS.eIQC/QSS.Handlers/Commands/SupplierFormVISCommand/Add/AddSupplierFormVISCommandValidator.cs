/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierFormVISCommandValidator : AbstractValidator<AddSupplierFormVISModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierFormVISCommandValidator()
        {


            RuleFor(r => r.SupplierFormId)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.AcceptanceQTY)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.TotalFailedQTY)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
