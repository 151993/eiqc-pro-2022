using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add
{

    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddPartInspectionDrawingAttachmentCommandValidator : AbstractValidator<AddPartInspectionDrawingAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddPartInspectionDrawingAttachmentCommandValidator()
        {
            RuleFor(r => r.SAPPartInspectionPlanId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AttachmentId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
