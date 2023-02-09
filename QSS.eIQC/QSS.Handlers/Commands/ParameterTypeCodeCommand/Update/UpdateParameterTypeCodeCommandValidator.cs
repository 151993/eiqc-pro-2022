/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateParameterTypeCodeCommandValidator : AbstractValidator<UpdateParameterTypeCodeModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateParameterTypeCodeCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ParameterManagementTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
