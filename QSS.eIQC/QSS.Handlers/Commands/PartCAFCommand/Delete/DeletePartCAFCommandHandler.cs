/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete PartCAF operation
    /// </summary>
    public class DeletePartCAFCommandHandler : IRequestHandler<DeletePartCAFModel, DeletePartCAFResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartCAFRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartCAFCommandHandler(QSSContext context, IPartCAFRepository partCAFRepository)
        {
            _context = context;
            _repository = partCAFRepository;
        }

        /// <summary>
        /// Handle the request to Delete PartCAF 
        /// </summary>
        /// <param name="request">Input Delete PartCAF model, <see cref="DeletePartCAFModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartCAFResponse"/></returns>
        public async Task<DeletePartCAFResponse> Handle(DeletePartCAFModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartCAFResponse()
            {
                Result = true
            };
        }
    }
}
