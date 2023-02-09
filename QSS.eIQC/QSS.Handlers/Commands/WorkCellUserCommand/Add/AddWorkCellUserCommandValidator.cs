/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddWorkCellUserCommandValidator : AbstractValidator<AddWorkCellUserModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddWorkCellUserCommandValidator()
        {

            RuleFor(r => r.WorkCellId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.SiteId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
