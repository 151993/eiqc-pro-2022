/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormLPositionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormLPosition operation
    /// </summary>
    public class DeleteFormLPositionCommandHandler : IRequestHandler<DeleteFormLPositionModel, DeleteFormLPositionResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormLPositionCommandHandler(QSSContext context, IFormLPositionRepository formLPositionRepository)
        {
            _context = context;
            _repository = formLPositionRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormLPosition 
        /// </summary>
        /// <param name="request">Input Delete FormLPosition model, <see cref="DeleteFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormLPositionResponse"/></returns>
        public async Task<DeleteFormLPositionResponse> Handle(DeleteFormLPositionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormLPositionResponse()
            {
                Result = true
            };
        }
    }
}
