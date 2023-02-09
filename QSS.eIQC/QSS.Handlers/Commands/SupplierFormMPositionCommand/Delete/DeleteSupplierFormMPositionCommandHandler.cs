/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMPosition operation
    /// </summary>
    public class DeleteSupplierFormMPositionCommandHandler : IRequestHandler<DeleteSupplierFormMPositionModel, DeleteSupplierFormMPositionResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMPositionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMPositionCommandHandler(QSSContext context, ISupplierFormMPositionRepository supplierFormMPositionRepository)
        {
            _context = context;
            _repository = supplierFormMPositionRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMPosition 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMPosition model, <see cref="DeleteSupplierFormMPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMPositionResponse"/></returns>
        public async Task<DeleteSupplierFormMPositionResponse> Handle(DeleteSupplierFormMPositionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMPositionResponse()
            {
                Result = true
            };
        }
    }
}
