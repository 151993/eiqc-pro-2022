/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierFormMeasurementParameter operation
    /// </summary>
    public class DeleteSupplierFormMeasurementParameterCommandHandler : IRequestHandler<DeleteSupplierFormMeasurementParameterModel, DeleteSupplierFormMeasurementParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMeasurementParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierFormMeasurementParameterCommandHandler(QSSContext context, ISupplierFormMeasurementParameterRepository supplierFormMeasurementParameterRepository)
        {
            _context = context;
            _repository = supplierFormMeasurementParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierFormMeasurementParameter 
        /// </summary>
        /// <param name="request">Input Delete SupplierFormMeasurementParameter model, <see cref="DeleteSupplierFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierFormMeasurementParameterResponse"/></returns>
        public async Task<DeleteSupplierFormMeasurementParameterResponse> Handle(DeleteSupplierFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierFormMeasurementParameterResponse()
            {
                Result = true
            };
        }
    }
}
