/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMeasurementParameter operation
    /// </summary>
    public class DeleteFormMeasurementParameterCommandHandler : IRequestHandler<DeleteFormMeasurementParameterModel, DeleteFormMeasurementParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMeasurementParameterCommandHandler(QSSContext context, IFormMeasurementParameterRepository formMeasurementParameterRepository)
        {
            _context = context;
            _repository = formMeasurementParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMeasurementParameter 
        /// </summary>
        /// <param name="request">Input Delete FormMeasurementParameter model, <see cref="DeleteFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMeasurementParameterResponse"/></returns>
        public async Task<DeleteFormMeasurementParameterResponse> Handle(DeleteFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMeasurementParameterResponse()
            {
                Result = true
            };
        }
    }
}
