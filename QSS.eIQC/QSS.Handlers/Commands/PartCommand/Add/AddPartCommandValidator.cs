/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddPartCommandValidator : AbstractValidator<AddPartModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartCommandValidator()
        {

            RuleFor(r => r.PartNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
