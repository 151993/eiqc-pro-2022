using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Delete
{
    public class DeletePartInspectionSpecAttachmentCommandValidator : AbstractValidator<DeletePartInspectionSpecAttachmentModel>
    {
        public DeletePartInspectionSpecAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                    .MaximumLength(256);
        }
    }
}
