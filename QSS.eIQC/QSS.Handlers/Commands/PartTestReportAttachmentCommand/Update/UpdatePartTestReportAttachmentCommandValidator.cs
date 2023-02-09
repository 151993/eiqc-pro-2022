using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Update
{

    public class UpdatePartTestReportAttachmentCommandValidator : AbstractValidator<UpdatePartTestReportAttachmentModel>
    {
        public UpdatePartTestReportAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.TestReportId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
        }
    }
}
