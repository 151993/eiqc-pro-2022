using FluentValidation;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Delete
{
	public class DeleteAdminCertificationAttachmentCommandHandler : IRequestHandler<DeleteAdminCertificationAttachmentModel, DeleteAdminCertificationAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly IAdminCertificationAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteAdminCertificationAttachmentCommandHandler(QSSContext context, IAdminCertificationAttachmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete AdminCertificationAttachment
        /// </summary>
        /// <param name="request">Input Delete CommodityAttachment model, <see cref="DeleteAdminCertificationAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteAdminCertificationAttachmentResponse"/></returns>
        public async Task<DeleteAdminCertificationAttachmentResponse> Handle(DeleteAdminCertificationAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteAdminCertificationAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
