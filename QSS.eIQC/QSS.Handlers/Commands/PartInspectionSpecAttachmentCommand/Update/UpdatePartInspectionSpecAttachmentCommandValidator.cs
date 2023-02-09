using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Update
{

    public class UpdatePartInspectionSpecAttachmentCommandValidator : AbstractValidator<UpdatePartInspectionSpecAttachmentModel>
    {
        public UpdatePartInspectionSpecAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.SAPPartInspectionPlanId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
