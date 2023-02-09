/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddCertificateTypeCommandValidator : AbstractValidator<AddCertificateTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddCertificateTypeCommandValidator()
        {
           
                RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
