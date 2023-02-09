/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete GRSSupplierForm operation
    /// </summary>
    public class DeleteGRSSupplierFormCommandHandler : IRequestHandler<DeleteGRSSupplierFormModel, DeleteGRSSupplierFormResponse>
    {
        private readonly QSSContext _context;
        private readonly IGRSSupplierFormRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteGRSSupplierFormCommandHandler(QSSContext context, IGRSSupplierFormRepository gRSSupplierFormRepository)
        {
            _context = context;
            _repository = gRSSupplierFormRepository;
        }

        /// <summary>
        /// Handle the request to Delete GRSSupplierForm 
        /// </summary>
        /// <param name="request">Input Delete GRSSupplierForm model, <see cref="DeleteGRSSupplierFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteGRSSupplierFormResponse"/></returns>
        public async Task<DeleteGRSSupplierFormResponse> Handle(DeleteGRSSupplierFormModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteGRSSupplierFormResponse()
            {
                Result = true
            };
        }
    }
}
