/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormPartDateCode operation
    /// </summary>
    public class DeleteSupplierFormPartDateCodeCommandHandler : IRequestHandler<DeleteSupplierFormPartDateCodeModel, DeleteSupplierFormPartDateCodeResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormPartDateCodeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormPartDateCodeCommandHandler(QSSContext context, ISupplierFormPartDateCodeRepository supplierFormPartDateCodeRepository)
        {
            _context = context;
            _repository = supplierFormPartDateCodeRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormPartDateCode 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormPartDateCode model, <see cref="DeleteSupplierFormPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormPartDateCodeResponse"/></returns>
        public async Task<DeleteSupplierFormPartDateCodeResponse> Handle(DeleteSupplierFormPartDateCodeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormPartDateCodeResponse()
            {
                Result = true
            };
        }
    }
}
