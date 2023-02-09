/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormVISCommandValidator : AbstractValidator<AddFormVISModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormVISCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);







            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
