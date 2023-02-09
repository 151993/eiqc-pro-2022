/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMicroSection operation
    /// </summary>
    public class DeleteSupplierFormMicroSectionCommandHandler : IRequestHandler<DeleteSupplierFormMicroSectionModel, DeleteSupplierFormMicroSectionResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMicroSectionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMicroSectionCommandHandler(QSSContext context, ISupplierFormMicroSectionRepository supplierFormMicroSectionRepository)
        {
            _context = context;
            _repository = supplierFormMicroSectionRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMicroSection 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMicroSection model, <see cref="DeleteSupplierFormMicroSectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMicroSectionResponse"/></returns>
        public async Task<DeleteSupplierFormMicroSectionResponse> Handle(DeleteSupplierFormMicroSectionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMicroSectionResponse()
            {
                Result = true
            };
        }
    }
}
