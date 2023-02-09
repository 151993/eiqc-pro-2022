using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.EmailTemplateCommand.Update
{
    /// <summary>
    /// Validator for Update EmailTemplate operation
    /// </summary>
    public class UpdateEmailTemplateCommandValidator : AbstractValidator<UpdateEmailTemplateModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateEmailTemplateCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.Subject).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.Body).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
