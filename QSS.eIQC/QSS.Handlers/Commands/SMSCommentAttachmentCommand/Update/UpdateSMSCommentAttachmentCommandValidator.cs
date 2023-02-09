using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Update
{

    public class UpdateSMSCommentAttachmentCommandValidator : AbstractValidator<UpdateSMSCommentAttachmentModel>
    {
        public UpdateSMSCommentAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.SupplierMeasurementSubmissionId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
