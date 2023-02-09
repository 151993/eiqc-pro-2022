/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateBuyerCommandValidator : AbstractValidator<UpdateBuyerModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateBuyerCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.BuyerCode).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.BuyerMail).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


            RuleFor(r => r.IsValid);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty).MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
