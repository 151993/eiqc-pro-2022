using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddPartInspectionSpecAttachmentCommandValidator : AbstractValidator<AddPartInspectionSpecAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartInspectionSpecAttachmentCommandValidator()
        {
            RuleFor(r => r.SAPPartInspectionPlanId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AttachmentId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
