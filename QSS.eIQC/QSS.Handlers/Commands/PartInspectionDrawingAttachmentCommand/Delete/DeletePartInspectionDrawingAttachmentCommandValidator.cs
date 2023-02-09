using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Delete
{

    public class DeletePartInspectionDrawingAttachmentCommandValidator : AbstractValidator<DeletePartInspectionDrawingAttachmentModel>
    {
        public DeletePartInspectionDrawingAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason).NotEmpty()
                    .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
