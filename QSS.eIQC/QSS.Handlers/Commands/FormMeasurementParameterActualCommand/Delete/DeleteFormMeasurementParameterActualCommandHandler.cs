/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMeasurementParameterActual operation
    /// </summary>
    public class DeleteFormMeasurementParameterActualCommandHandler : IRequestHandler<DeleteFormMeasurementParameterActualModel, DeleteFormMeasurementParameterActualResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMeasurementParameterActualCommandHandler(QSSContext context, IFormMeasurementParameterActualRepository formMeasurementParameterActualRepository)
        {
            _context = context;
            _repository = formMeasurementParameterActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMeasurementParameterActual 
        /// </summary>
        /// <param name="request">Input Delete FormMeasurementParameterActual model, <see cref="DeleteFormMeasurementParameterActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMeasurementParameterActualResponse"/></returns>
        public async Task<DeleteFormMeasurementParameterActualResponse> Handle(DeleteFormMeasurementParameterActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMeasurementParameterActualResponse()
            {
                Result = true
            };
        }
    }
}
