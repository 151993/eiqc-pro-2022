using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Delete
{
    public class DeleteSMSCommentAttachmentCommandValidator : AbstractValidator<DeleteSMSCommentAttachmentModel>
    {
        public DeleteSMSCommentAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                    .MaximumLength(256);
        }
    }
}
