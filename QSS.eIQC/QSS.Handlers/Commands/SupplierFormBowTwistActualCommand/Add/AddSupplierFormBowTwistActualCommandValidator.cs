/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierFormBowTwistActualCommandValidator : AbstractValidator<AddSupplierFormBowTwistActualModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierFormBowTwistActualCommandValidator()
        {


            RuleFor(r => r.SupplierFormId)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.WarpType)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.No)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ValueActual);


            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
