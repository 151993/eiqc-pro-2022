using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.UserCommand.Add
{
    /// <summary>
    /// Validator for Add User operation
    /// </summary>
    public class AddUserCommandValidator : AbstractValidator<AddUserModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddUserCommandValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(300).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(300));

            RuleFor(r => r.UserName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));

            RuleFor(r => r.Email).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));

            RuleFor(r => r.SiteId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
