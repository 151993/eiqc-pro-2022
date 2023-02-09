/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormFunPara operation
    /// </summary>
    public class DeleteSupplierFormFunParaCommandHandler : IRequestHandler<DeleteSupplierFormFunParaModel, DeleteSupplierFormFunParaResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormFunParaRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormFunParaCommandHandler(QSSContext context, ISupplierFormFunParaRepository supplierFormFunParaRepository)
        {
            _context = context;
            _repository = supplierFormFunParaRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormFunPara 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormFunPara model, <see cref="DeleteSupplierFormFunParaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormFunParaResponse"/></returns>
        public async Task<DeleteSupplierFormFunParaResponse> Handle(DeleteSupplierFormFunParaModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormFunParaResponse()
            {
                Result = true
            };
        }
    }
}
