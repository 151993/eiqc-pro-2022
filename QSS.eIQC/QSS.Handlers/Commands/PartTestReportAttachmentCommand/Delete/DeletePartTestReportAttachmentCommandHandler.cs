using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Delete
{
    public class DeletePartTestReportAttachmentCommandHandler : IRequestHandler<DeletePartTestReportAttachmentModel, DeletePartTestReportAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartTestReportAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartTestReportAttachmentCommandHandler(QSSContext context, IPartTestReportAttachmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete TestReportAttachment
        /// </summary>
        /// <param name="request">Input Delete PartTestReportAttachment model, <see cref="DeletePartTestReportAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartInspectionDrawingAttachmentResponse"/></returns>
        public async Task<DeletePartTestReportAttachmentResponse> Handle(DeletePartTestReportAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartTestReportAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
