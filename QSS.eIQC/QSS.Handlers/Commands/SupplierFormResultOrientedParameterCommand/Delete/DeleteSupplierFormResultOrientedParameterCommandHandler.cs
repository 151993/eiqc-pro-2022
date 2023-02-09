/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormResultOrientedParameter operation
    /// </summary>
    public class DeleteSupplierFormResultOrientedParameterCommandHandler : IRequestHandler<DeleteSupplierFormResultOrientedParameterModel, DeleteSupplierFormResultOrientedParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormResultOrientedParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormResultOrientedParameterCommandHandler(QSSContext context, ISupplierFormResultOrientedParameterRepository supplierFormResultOrientedParameterRepository)
        {
            _context = context;
            _repository = supplierFormResultOrientedParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormResultOrientedParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormResultOrientedParameter model, <see cref="DeleteSupplierFormResultOrientedParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormResultOrientedParameterResponse"/></returns>
        public async Task<DeleteSupplierFormResultOrientedParameterResponse> Handle(DeleteSupplierFormResultOrientedParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormResultOrientedParameterResponse()
            {
                Result = true
            };
        }
    }
}
