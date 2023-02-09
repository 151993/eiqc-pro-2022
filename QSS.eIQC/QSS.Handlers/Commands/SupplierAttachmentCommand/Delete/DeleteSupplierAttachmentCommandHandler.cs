/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierAttachment operation
    /// </summary>
    public class DeleteSupplierAttachmentCommandHandler : IRequestHandler<DeleteSupplierAttachmentModel, DeleteSupplierAttachmentResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierAttachmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierAttachmentCommandHandler(QSSContext context, ISupplierAttachmentRepository supplierAttachmentRepository)
        {
            _context = context;
            _repository = supplierAttachmentRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierAttachment 
        /// </summary>
        /// <param name="request">Input Delete SupplierAttachment model, <see cref="DeleteSupplierAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierAttachmentResponse"/></returns>
        public async Task<DeleteSupplierAttachmentResponse> Handle(DeleteSupplierAttachmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierAttachmentResponse()
            {
                Result = true
            };
        }
    }
}
