using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Add
{
    /// <summary>
    /// Validator for Add ParameterManagement operation
    /// </summary>
    public class AddParameterManagementCommandValidator : AbstractValidator<AddParameterManagementModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddParameterManagementCommandValidator()
        {

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(150).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(150));

            RuleFor(r => r.ParameterTypeCodeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason)
           .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
