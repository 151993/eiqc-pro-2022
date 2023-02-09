/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMPositionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMPosition operation
    /// </summary>
    public class DeleteFormMPositionCommandHandler : IRequestHandler<DeleteFormMPositionModel, DeleteFormMPositionResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMPositionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMPositionCommandHandler(QSSContext context, IFormMPositionRepository formMPositionRepository)
        {
            _context = context;
            _repository = formMPositionRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMPosition 
        /// </summary>
        /// <param name="request">Input Delete FormMPosition model, <see cref="DeleteFormMPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMPositionResponse"/></returns>
        public async Task<DeleteFormMPositionResponse> Handle(DeleteFormMPositionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMPositionResponse()
            {
                Result = true
            };
        }
    }
}
