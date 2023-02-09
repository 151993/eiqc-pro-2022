/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CustomerCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddCustomerCommandValidator : AbstractValidator<AddCustomerModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddCustomerCommandValidator()
        {
           
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.CAFPath)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.DCCSavePath)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.CAFTempPath)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.BackupSavePath)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

           // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
