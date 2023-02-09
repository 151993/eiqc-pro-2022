using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Update
{

    public class UpdatePartInspectionDrawingAttachmentCommandValidator : AbstractValidator<UpdatePartInspectionDrawingAttachmentModel>
    {
        public UpdatePartInspectionDrawingAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.AdminCertificateId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
