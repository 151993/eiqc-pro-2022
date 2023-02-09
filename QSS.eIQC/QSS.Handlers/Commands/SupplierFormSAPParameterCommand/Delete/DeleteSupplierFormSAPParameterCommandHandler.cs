/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormSAPParameter operation
    /// </summary>
    public class DeleteSupplierFormSAPParameterCommandHandler : IRequestHandler<DeleteSupplierFormSAPParameterModel, DeleteSupplierFormSAPParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSAPParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormSAPParameterCommandHandler(QSSContext context, ISupplierFormSAPParameterRepository supplierFormSAPParameterRepository)
        {
            _context = context;
            _repository = supplierFormSAPParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormSAPParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormSAPParameter model, <see cref="DeleteSupplierFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormSAPParameterResponse"/></returns>
        public async Task<DeleteSupplierFormSAPParameterResponse> Handle(DeleteSupplierFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormSAPParameterResponse()
            {
                Result = true
            };
        }
    }
}
