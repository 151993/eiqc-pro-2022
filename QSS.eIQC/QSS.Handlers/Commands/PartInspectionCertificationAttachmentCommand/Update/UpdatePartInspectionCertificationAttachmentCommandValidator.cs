using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Update
{

    public class UpdatePartInspectionCertificationAttachmentCommandValidator : AbstractValidator<UpdatePartInspectionCertificationAttachmentModel>
    {
        public UpdatePartInspectionCertificationAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.SAPPartInspectionPlanId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
