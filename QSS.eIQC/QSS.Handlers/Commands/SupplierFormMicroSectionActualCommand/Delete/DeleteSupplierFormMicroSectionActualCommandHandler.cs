/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMicroSectionActual operation
    /// </summary>
    public class DeleteSupplierFormMicroSectionActualCommandHandler : IRequestHandler<DeleteSupplierFormMicroSectionActualModel, DeleteSupplierFormMicroSectionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMicroSectionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMicroSectionActualCommandHandler(QSSContext context, ISupplierFormMicroSectionActualRepository supplierFormMicroSectionActualRepository)
        {
            _context = context;
            _repository = supplierFormMicroSectionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMicroSectionActual 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMicroSectionActual model, <see cref="DeleteSupplierFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMicroSectionActualResponse"/></returns>
        public async Task<DeleteSupplierFormMicroSectionActualResponse> Handle(DeleteSupplierFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMicroSectionActualResponse()
            {
                Result = true
            };
        }
    }
}
