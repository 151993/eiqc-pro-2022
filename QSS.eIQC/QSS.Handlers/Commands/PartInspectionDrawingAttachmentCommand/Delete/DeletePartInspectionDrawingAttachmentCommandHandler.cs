using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Delete
{
    public class DeletePartInspectionDrawingAttachmentCommandHandler : IRequestHandler<DeletePartInspectionDrawingAttachmentModel, DeletePartInspectionDrawingAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionDrawingAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartInspectionDrawingAttachmentCommandHandler(QSSContext context, IPartInspectionDrawingAttachmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete AdminCertificationAttachment
        /// </summary>
        /// <param name="request">Input Delete CommodityAttachment model, <see cref="DeletePartInspectionDrawingAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartInspectionDrawingAttachmentResponse"/></returns>
        public async Task<DeletePartInspectionDrawingAttachmentResponse> Handle(DeletePartInspectionDrawingAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartInspectionDrawingAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
