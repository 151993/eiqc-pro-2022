using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Delete
{
    /// <summary>
    /// Validator for Delete ParameterManagement operation
    /// </summary>
    public class DeleteParameterManagementCommandValidator : AbstractValidator<DeleteParameterManagementModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public DeleteParameterManagementCommandValidator()
        {
            // Property validations
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
