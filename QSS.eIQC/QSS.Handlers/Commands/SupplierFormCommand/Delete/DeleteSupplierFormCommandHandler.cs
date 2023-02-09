/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierForm operation
    /// </summary>
    public class DeleteSupplierFormCommandHandler : IRequestHandler<DeleteSupplierFormModel, DeleteSupplierFormResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormCommandHandler(QSSContext context, ISupplierFormRepository supplierFormRepository)
        {
            _context = context;
            _repository = supplierFormRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierForm 
        /// </summary>
        /// <param name="request">Input Delete SupplierForm model, <see cref="DeleteSupplierFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormResponse"/></returns>
        public async Task<DeleteSupplierFormResponse> Handle(DeleteSupplierFormModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormResponse()
            {
                Result = true
            };
        }
    }
}
