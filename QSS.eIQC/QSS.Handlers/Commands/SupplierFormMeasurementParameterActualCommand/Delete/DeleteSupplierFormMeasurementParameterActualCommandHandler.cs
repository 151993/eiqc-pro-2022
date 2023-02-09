/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMeasurementParameterActual operation
    /// </summary>
    public class DeleteSupplierFormMeasurementParameterActualCommandHandler : IRequestHandler<DeleteSupplierFormMeasurementParameterActualModel, DeleteSupplierFormMeasurementParameterActualResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMeasurementParameterActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMeasurementParameterActualCommandHandler(QSSContext context, ISupplierFormMeasurementParameterActualRepository supplierFormMeasurementParameterActualRepository)
        {
            _context = context;
            _repository = supplierFormMeasurementParameterActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMeasurementParameterActual 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMeasurementParameterActual model, <see cref="DeleteSupplierFormMeasurementParameterActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMeasurementParameterActualResponse"/></returns>
        public async Task<DeleteSupplierFormMeasurementParameterActualResponse> Handle(DeleteSupplierFormMeasurementParameterActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMeasurementParameterActualResponse()
            {
                Result = true
            };
        }
    }
}
