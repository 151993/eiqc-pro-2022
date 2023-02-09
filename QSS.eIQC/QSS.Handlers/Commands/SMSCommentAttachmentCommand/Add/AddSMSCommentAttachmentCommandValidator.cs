using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddSMSCommentAttachmentCommandValidator : AbstractValidator<AddSMSCommentAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSMSCommentAttachmentCommandValidator()
        {
            RuleFor(r => r.SupplierMeasurementSubmissionId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AttachmentId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
