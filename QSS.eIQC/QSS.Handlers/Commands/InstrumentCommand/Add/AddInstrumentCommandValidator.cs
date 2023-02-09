/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddInstrumentCommandValidator : AbstractValidator<AddInstrumentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddInstrumentCommandValidator()
        {

            RuleFor(r => r.InstrumentNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


            RuleFor(r => r.ValidDate).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.InstrumentTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
