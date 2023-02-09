using FluentValidation;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Update
{
	public class UpdateAdminCertificationAttachmentCommandValidator : AbstractValidator<UpdateAdminCertificationAttachmentModel>
    {
        public UpdateAdminCertificationAttachmentCommandValidator()
        {
	        RuleFor(r => r.Id).NotEmpty().WithMessage("{PropertyName} can not be null.");
	        RuleFor(r => r.AdminCertificateId).NotEmpty().WithMessage("{PropertyName} can not be null.");
        }
    }
}
