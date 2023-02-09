/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddInspectionCommandValidator : AbstractValidator<AddInspectionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddInspectionCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


                RuleFor(r => r.Inspector).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));


                RuleFor(r => r.InspectionResult).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.ReportFullName).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
