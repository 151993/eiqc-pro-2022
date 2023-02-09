/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierFormMPositionCommandValidator : AbstractValidator<AddSupplierFormMPositionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierFormMPositionCommandValidator()
        {


            RuleFor(r => r.SupplierFormId)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.LineNo)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            RuleFor(r => r.ITCode)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            RuleFor(r => r.UOM)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));

            RuleFor(r => r.Spec);

            RuleFor(r => r.UpperLimit1);


            RuleFor(r => r.ITCode1)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.ITCode2)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.UpperLimit3);

            RuleFor(r => r.LowerLimit3);

            RuleFor(r => r.ITCode3)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.PositionType);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
