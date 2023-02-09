/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddPCCodeInspectionToolsTypeCommandValidator : AbstractValidator<AddPCCodeInspectionToolsTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPCCodeInspectionToolsTypeCommandValidator()
        {
           



                RuleFor(r => r.PCCodeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);




                RuleFor(r => r.InspectionToolsTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
