/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMPositionActual operation
    /// </summary>
    public class DeleteSupplierFormMPositionActualCommandHandler : IRequestHandler<DeleteSupplierFormMPositionActualModel, DeleteSupplierFormMPositionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMPositionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMPositionActualCommandHandler(QSSContext context, ISupplierFormMPositionActualRepository supplierFormMPositionActualRepository)
        {
            _context = context;
            _repository = supplierFormMPositionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMPositionActual 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMPositionActual model, <see cref="DeleteSupplierFormMPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMPositionActualResponse"/></returns>
        public async Task<DeleteSupplierFormMPositionActualResponse> Handle(DeleteSupplierFormMPositionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMPositionActualResponse()
            {
                Result = true
            };
        }
    }
}
