using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete
{
    public class DeleteWorkCellCommandValidator : AbstractValidator<DeleteWorkCellModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public DeleteWorkCellCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
