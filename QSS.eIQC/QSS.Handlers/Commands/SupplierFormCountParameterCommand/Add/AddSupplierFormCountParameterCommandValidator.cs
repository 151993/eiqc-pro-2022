/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierFormCountParameterCommandValidator : AbstractValidator<AddSupplierFormCountParameterModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierFormCountParameterCommandValidator()
        {


            RuleFor(r => r.SupplierFormId)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ParameterName)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));

            RuleFor(r => r.FailedQTYExpected);

            RuleFor(r => r.FailedQTYActual);

            RuleFor(r => r.IToolsID);

            RuleFor(r => r.Remark)
                .MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));

            RuleFor(r => r.InspectionDetails)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
