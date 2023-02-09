/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormBowTwistParameter operation
    /// </summary>
    public class DeleteSupplierFormBowTwistParameterCommandHandler : IRequestHandler<DeleteSupplierFormBowTwistParameterModel, DeleteSupplierFormBowTwistParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormBowTwistParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormBowTwistParameterCommandHandler(QSSContext context, ISupplierFormBowTwistParameterRepository supplierFormBowTwistParameterRepository)
        {
            _context = context;
            _repository = supplierFormBowTwistParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormBowTwistParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormBowTwistParameter model, <see cref="DeleteSupplierFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormBowTwistParameterResponse"/></returns>
        public async Task<DeleteSupplierFormBowTwistParameterResponse> Handle(DeleteSupplierFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormBowTwistParameterResponse()
            {
                Result = true
            };
        }
    }
}
