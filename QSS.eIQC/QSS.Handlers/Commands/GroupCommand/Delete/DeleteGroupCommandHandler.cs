/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Group operation
    /// </summary>
    public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupModel, DeleteGroupResponse>
    {
        private readonly QSSContext _context;
        private readonly IGroupRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteGroupCommandHandler(QSSContext context, IGroupRepository groupRepository)
        {
            _context = context;
            _repository = groupRepository;
        }

        /// <summary>
        /// Handle the request to Delete Group 
        /// </summary>
        /// <param name="request">Input Delete Group model, <see cref="DeleteGroupModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> Handle(DeleteGroupModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteGroupResponse()
            {
                Result = true
            };
        }
    }
}
