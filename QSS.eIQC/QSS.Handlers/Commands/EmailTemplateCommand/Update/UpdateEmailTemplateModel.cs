using MediatR;

namespace QSS.eIQC.Handlers.Commands.EmailTemplateCommand.Update
{
    /// <summary>
    /// Representation model for Update EmailTemplate operation
    /// </summary>
    public class UpdateEmailTemplateModel : BaseUpdateCommand<int>, IRequest<EmailTemplateModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set Subject property
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Get or set Body property
        /// </summary>
        public string Body { get; set; }
    }
}
