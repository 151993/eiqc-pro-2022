using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddRoleCommandValidator : AbstractValidator<AddRoleModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddRoleCommandValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
               .MaximumLength(60).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(60));

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
