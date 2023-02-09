using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Update
{
    /// <summary>
    /// Validator for Update Country operation
    /// </summary>
    public class UpdateCountryCommandValidator : AbstractValidator<UpdateCountryModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateCountryCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.RegionId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
