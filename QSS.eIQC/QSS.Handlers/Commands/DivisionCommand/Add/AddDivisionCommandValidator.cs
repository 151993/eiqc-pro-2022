using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Add
{
    /// <summary>
    /// Validator for Add Division operation
    /// </summary>
    public class AddDivisionCommandValidator : AbstractValidator<AddDivisionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddDivisionCommandValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
