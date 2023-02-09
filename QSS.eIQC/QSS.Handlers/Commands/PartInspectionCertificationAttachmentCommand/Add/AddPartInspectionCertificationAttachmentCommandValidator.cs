using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddPartInspectionCertificationAttachmentCommandValidator : AbstractValidator<AddPartInspectionCertificationAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartInspectionCertificationAttachmentCommandValidator()
        {
            RuleFor(r => r.SAPPartInspectionPlanId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AttachmentId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
