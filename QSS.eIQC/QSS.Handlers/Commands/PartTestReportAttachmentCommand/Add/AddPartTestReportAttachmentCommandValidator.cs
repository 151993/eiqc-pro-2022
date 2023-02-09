using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddPartTestReportAttachmentCommandValidator : AbstractValidator<AddPartTestReportAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartTestReportAttachmentCommandValidator()
        {
            RuleFor(r => r.TestReportId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AttachmentId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
