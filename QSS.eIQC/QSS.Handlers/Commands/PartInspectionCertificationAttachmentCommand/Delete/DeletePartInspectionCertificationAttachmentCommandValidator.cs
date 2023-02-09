using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Delete
{
    public class DeletePartInspectionCertificationAttachmentCommandValidator : AbstractValidator<DeletePartInspectionCertificationAttachmentModel>
    {
        public DeletePartInspectionCertificationAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                    .MaximumLength(256);
        }
    }
}
