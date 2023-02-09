/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete WorkCellUser operation
    /// </summary>
    public class DeleteWorkCellUserCommandHandler : IRequestHandler<DeleteWorkCellUserModel, DeleteWorkCellUserResponse>
    {
        private readonly QSSContext _context;
        private readonly IWorkCellUserRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteWorkCellUserCommandHandler(QSSContext context, IWorkCellUserRepository workCellUserRepository)
        {
            _context = context;
            _repository = workCellUserRepository;
        }

        /// <summary>
        /// Handle the request to Delete WorkCellUser 
        /// </summary>
        /// <param name="request">Input Delete WorkCellUser model, <see cref="DeleteWorkCellUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteWorkCellUserResponse"/></returns>
        public async Task<DeleteWorkCellUserResponse> Handle(DeleteWorkCellUserModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteWorkCellUserResponse()
            {
                Result = true
            };
        }
    }
}
