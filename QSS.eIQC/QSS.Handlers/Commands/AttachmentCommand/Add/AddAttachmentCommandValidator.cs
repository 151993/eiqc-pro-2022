using FluentValidation;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand.Add
{
    /// <summary>
    /// Validator for Add operation
    /// </summary>
    public class AddAttachmentCommandValidator : AbstractValidator<AddAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddAttachmentCommandValidator()
        {
	        RuleFor(r => r.Name).NotEmpty().WithMessage("{PropertyName} can not be empty.");
	        RuleFor(r => r.SavePath).NotEmpty().WithMessage("{PropertyName} can not be empty.");
        }
    }
}
