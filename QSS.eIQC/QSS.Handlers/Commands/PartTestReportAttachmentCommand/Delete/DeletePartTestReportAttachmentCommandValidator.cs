using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Delete
{
    public class DeletePartTestReportAttachmentCommandValidator : AbstractValidator<DeletePartTestReportAttachmentModel>
    {
        public DeletePartTestReportAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                    .MaximumLength(256);
        }
    }
}
