/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormVIS operation
    /// </summary>
    public class DeleteSupplierFormVISCommandHandler : IRequestHandler<DeleteSupplierFormVISModel, DeleteSupplierFormVISResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormVISRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormVISCommandHandler(QSSContext context, ISupplierFormVISRepository supplierFormVISRepository)
        {
            _context = context;
            _repository = supplierFormVISRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormVIS 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormVIS model, <see cref="DeleteSupplierFormVISModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormVISResponse"/></returns>
        public async Task<DeleteSupplierFormVISResponse> Handle(DeleteSupplierFormVISModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormVISResponse()
            {
                Result = true
            };
        }
    }
}
