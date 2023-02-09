/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormSpecialParameter operation
    /// </summary>
    public class DeleteSupplierFormSpecialParameterCommandHandler : IRequestHandler<DeleteSupplierFormSpecialParameterModel, DeleteSupplierFormSpecialParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSpecialParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormSpecialParameterCommandHandler(QSSContext context, ISupplierFormSpecialParameterRepository supplierFormSpecialParameterRepository)
        {
            _context = context;
            _repository = supplierFormSpecialParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormSpecialParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormSpecialParameter model, <see cref="DeleteSupplierFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormSpecialParameterResponse"/></returns>
        public async Task<DeleteSupplierFormSpecialParameterResponse> Handle(DeleteSupplierFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormSpecialParameterResponse()
            {
                Result = true
            };
        }
    }
}
