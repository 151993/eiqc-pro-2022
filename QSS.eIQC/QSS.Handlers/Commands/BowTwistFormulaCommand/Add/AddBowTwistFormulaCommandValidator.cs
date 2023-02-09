
using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddBowTwistFormulaCommandValidator : AbstractValidator<AddBowTwistFormulaModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddBowTwistFormulaCommandValidator()
        {
            RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Equation).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
