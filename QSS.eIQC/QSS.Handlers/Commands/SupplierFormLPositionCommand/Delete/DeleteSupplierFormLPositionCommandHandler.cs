/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormLPosition operation
    /// </summary>
    public class DeleteSupplierFormLPositionCommandHandler : IRequestHandler<DeleteSupplierFormLPositionModel, DeleteSupplierFormLPositionResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormLPositionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormLPositionCommandHandler(QSSContext context, ISupplierFormLPositionRepository supplierFormLPositionRepository)
        {
            _context = context;
            _repository = supplierFormLPositionRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormLPosition 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormLPosition model, <see cref="DeleteSupplierFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormLPositionResponse"/></returns>
        public async Task<DeleteSupplierFormLPositionResponse> Handle(DeleteSupplierFormLPositionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormLPositionResponse()
            {
                Result = true
            };
        }
    }
}
