/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormLPositionActual operation
    /// </summary>
    public class DeleteSupplierFormLPositionActualCommandHandler : IRequestHandler<DeleteSupplierFormLPositionActualModel, DeleteSupplierFormLPositionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormLPositionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormLPositionActualCommandHandler(QSSContext context, ISupplierFormLPositionActualRepository supplierFormLPositionActualRepository)
        {
            _context = context;
            _repository = supplierFormLPositionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormLPositionActual 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormLPositionActual model, <see cref="DeleteSupplierFormLPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormLPositionActualResponse"/></returns>
        public async Task<DeleteSupplierFormLPositionActualResponse> Handle(DeleteSupplierFormLPositionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormLPositionActualResponse()
            {
                Result = true
            };
        }
    }
}
