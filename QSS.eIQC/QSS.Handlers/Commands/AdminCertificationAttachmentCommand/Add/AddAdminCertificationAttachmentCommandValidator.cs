using FluentValidation;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddAdminCertificationAttachmentCommandValidator : AbstractValidator<AddAdminCertificationAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddAdminCertificationAttachmentCommandValidator()
        {
	        RuleFor(r => r.AdminCertificateId).NotEmpty().WithMessage("{PropertyName} can not be empty.");
	        RuleFor(r => r.AttachmentId).NotEmpty().WithMessage("{PropertyName} can not be empty.");
        }
    }
}
