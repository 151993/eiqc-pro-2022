/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateInstrumentTypeCommandValidator : AbstractValidator<UpdateInstrumentTypeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateInstrumentTypeCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Code)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description)
                .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
