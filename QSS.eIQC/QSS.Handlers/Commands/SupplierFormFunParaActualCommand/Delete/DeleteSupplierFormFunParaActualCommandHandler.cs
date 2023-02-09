/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormFunParaActual operation
    /// </summary>
    public class DeleteSupplierFormFunParaActualCommandHandler : IRequestHandler<DeleteSupplierFormFunParaActualModel, DeleteSupplierFormFunParaActualResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormFunParaActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormFunParaActualCommandHandler(QSSContext context, ISupplierFormFunParaActualRepository supplierFormFunParaActualRepository)
        {
            _context = context;
            _repository = supplierFormFunParaActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormFunParaActual 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormFunParaActual model, <see cref="DeleteSupplierFormFunParaActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormFunParaActualResponse"/></returns>
        public async Task<DeleteSupplierFormFunParaActualResponse> Handle(DeleteSupplierFormFunParaActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormFunParaActualResponse()
            {
                Result = true
            };
        }
    }
}
