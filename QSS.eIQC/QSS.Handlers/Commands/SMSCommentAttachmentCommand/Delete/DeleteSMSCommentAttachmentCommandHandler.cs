using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Delete
{
    public class DeleteSMSCommentAttachmentCommandHandler : IRequestHandler<DeleteSMSCommentAttachmentModel, DeleteSMSCommentAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly ISMSCommentAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSMSCommentAttachmentCommandHandler(QSSContext context, ISMSCommentAttachmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierMeasurementSubmissionAttachment
        /// </summary>
        /// <param name="request">Input Delete SMSCommentAttachment model, <see cref="DeleteSMSCommentAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartInspectionDrawingAttachmentResponse"/></returns>
        public async Task<DeleteSMSCommentAttachmentResponse> Handle(DeleteSMSCommentAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSMSCommentAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
