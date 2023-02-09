/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormPackaging operation
    /// </summary>
    public class DeleteSupplierFormPackagingCommandHandler : IRequestHandler<DeleteSupplierFormPackagingModel, DeleteSupplierFormPackagingResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormPackagingRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormPackagingCommandHandler(QSSContext context, ISupplierFormPackagingRepository supplierFormPackagingRepository)
        {
            _context = context;
            _repository = supplierFormPackagingRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormPackaging 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormPackaging model, <see cref="DeleteSupplierFormPackagingModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormPackagingResponse"/></returns>
        public async Task<DeleteSupplierFormPackagingResponse> Handle(DeleteSupplierFormPackagingModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormPackagingResponse()
            {
                Result = true
            };
        }
    }
}
