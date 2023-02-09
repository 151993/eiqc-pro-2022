/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SupplierMeasurementSubmission operation
    /// </summary>
    public class DeleteSupplierMeasurementSubmissionCommandHandler : IRequestHandler<DeleteSupplierMeasurementSubmissionModel, DeleteSupplierMeasurementSubmissionResponse>
    {
        private readonly QSSContext _context;
        private readonly ISupplierMeasurementSubmissionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSupplierMeasurementSubmissionCommandHandler(QSSContext context, ISupplierMeasurementSubmissionRepository supplierMeasurementSubmissionRepository)
        {
            _context = context;
            _repository = supplierMeasurementSubmissionRepository;
        }

        /// <summary>
        /// Handle the request to Delete SupplierMeasurementSubmission 
        /// </summary>
        /// <param name="request">Input Delete SupplierMeasurementSubmission model, <see cref="DeleteSupplierMeasurementSubmissionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSupplierMeasurementSubmissionResponse"/></returns>
        public async Task<DeleteSupplierMeasurementSubmissionResponse> Handle(DeleteSupplierMeasurementSubmissionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSupplierMeasurementSubmissionResponse()
            {
                Result = true
            };
        }
    }
}
