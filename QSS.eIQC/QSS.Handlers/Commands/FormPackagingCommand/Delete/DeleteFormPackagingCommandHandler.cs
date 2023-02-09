/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormPackaging operation
    /// </summary>
    public class DeleteFormPackagingCommandHandler : IRequestHandler<DeleteFormPackagingModel, DeleteFormPackagingResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormPackagingRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormPackagingCommandHandler(QSSContext context, IFormPackagingRepository formPackagingRepository)
        {
            _context = context;
            _repository = formPackagingRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormPackaging 
        /// </summary>
        /// <param name="request">Input Delete FormPackaging model, <see cref="DeleteFormPackagingModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormPackagingResponse"/></returns>
        public async Task<DeleteFormPackagingResponse> Handle(DeleteFormPackagingModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormPackagingResponse()
            {
                Result = true
            };
        }
    }
}
