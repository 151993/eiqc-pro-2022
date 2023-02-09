/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PartDimensionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete PartDimension operation
    /// </summary>
    public class DeletePartDimensionCommandHandler : IRequestHandler<DeletePartDimensionModel, DeletePartDimensionResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartDimensionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartDimensionCommandHandler(QSSContext context, IPartDimensionRepository partDimensionRepository)
        {
            _context = context;
            _repository = partDimensionRepository;
        }

        /// <summary>
        /// Handle the request to Delete PartDimension 
        /// </summary>
        /// <param name="request">Input Delete PartDimension model, <see cref="DeletePartDimensionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartDimensionResponse"/></returns>
        public async Task<DeletePartDimensionResponse> Handle(DeletePartDimensionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartDimensionResponse()
            {
                Result = true
            };
        }
    }
}
