using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Delete
{
    public class DeletePartInspectionSpecAttachmentCommandHandler : IRequestHandler<DeletePartInspectionSpecAttachmentModel, DeletePartInspectionSpecAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionSpecAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartInspectionSpecAttachmentCommandHandler(QSSContext context, IPartInspectionSpecAttachmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete SAPPartInspectionPlanAttachment
        /// </summary>
        /// <param name="request">Input Delete PartInspectionSpecAttachment model, <see cref="DeletePartInspectionSpecAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartInspectionDrawingAttachmentResponse"/></returns>
        public async Task<DeletePartInspectionSpecAttachmentResponse> Handle(DeletePartInspectionSpecAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartInspectionSpecAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
