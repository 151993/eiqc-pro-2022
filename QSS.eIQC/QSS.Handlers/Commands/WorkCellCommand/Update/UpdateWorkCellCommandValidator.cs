using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Update
{
    /// <summary>
    /// Validator for Update WorkCell operation
    /// </summary>
    public class UpdateWorkCellCommandValidator : AbstractValidator<UpdateWorkCellModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateWorkCellCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description)
           .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
           .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
