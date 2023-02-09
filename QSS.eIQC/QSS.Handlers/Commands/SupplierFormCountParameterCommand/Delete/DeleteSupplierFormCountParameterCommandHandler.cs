/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormCountParameter operation
    /// </summary>
    public class DeleteSupplierFormCountParameterCommandHandler : IRequestHandler<DeleteSupplierFormCountParameterModel, DeleteSupplierFormCountParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormCountParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormCountParameterCommandHandler(QSSContext context, ISupplierFormCountParameterRepository supplierFormCountParameterRepository)
        {
            _context = context;
            _repository = supplierFormCountParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormCountParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormCountParameter model, <see cref="DeleteSupplierFormCountParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormCountParameterResponse"/></returns>
        public async Task<DeleteSupplierFormCountParameterResponse> Handle(DeleteSupplierFormCountParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormCountParameterResponse()
            {
                Result = true
            };
        }
    }
}
