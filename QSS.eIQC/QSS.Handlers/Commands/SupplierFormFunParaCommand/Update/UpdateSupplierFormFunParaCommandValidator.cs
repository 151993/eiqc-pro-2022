/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateSupplierFormFunParaCommandValidator : AbstractValidator<UpdateSupplierFormFunParaModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateSupplierFormFunParaCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);


            RuleFor(r => r.SupplierFormId)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ParameterName)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));

            RuleFor(r => r.InstrumentID)
                .MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            RuleFor(r => r.ITCode)
                .MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            RuleFor(r => r.UOM)
                .MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));

            RuleFor(r => r.SampleSize)
                .MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
