/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Supplier operation
    /// </summary>
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierModel, DeleteSupplierResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierCommandHandler(QSSContext context, ISupplierRepository supplierRepository)
        {
            _context = context;
            _repository = supplierRepository;
        }

        /// <summary>
        /// Handle the request to Delete Supplier 
        /// </summary>
        /// <param name="request">Input Delete Supplier model, <see cref="DeleteSupplierModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierResponse"/></returns>
        public async Task<DeleteSupplierResponse> Handle(DeleteSupplierModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierResponse()
            {
                Result = true
            };
        }
    }
}
