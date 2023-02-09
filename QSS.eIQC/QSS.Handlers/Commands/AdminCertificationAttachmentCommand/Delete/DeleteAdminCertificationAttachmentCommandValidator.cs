using FluentValidation;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Delete
{
	public class DeleteAdminCertificationAttachmentCommandValidator : AbstractValidator<DeleteAdminCertificationAttachmentModel>
    {
        public DeleteAdminCertificationAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage("{PropertyName} must be provided.");

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage("{PropertyName} can not be empty.")
                    .MaximumLength(256).WithMessage("{PropertyName} can not be exceed 256 characters.");
        }
    }
}
