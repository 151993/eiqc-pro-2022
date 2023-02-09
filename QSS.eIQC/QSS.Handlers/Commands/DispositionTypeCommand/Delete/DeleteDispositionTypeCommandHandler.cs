/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete DispositionType operation
    /// </summary>
    public class DeleteDispositionTypeCommandHandler : IRequestHandler<DeleteDispositionTypeModel, DeleteDispositionTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IDispositionTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteDispositionTypeCommandHandler(QSSContext context, IDispositionTypeRepository dispositionTypeRepository)
        {
            _context = context;
            _repository = dispositionTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete DispositionType 
        /// </summary>
        /// <param name="request">Input Delete DispositionType model, <see cref="DeleteDispositionTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteDispositionTypeResponse"/></returns>
        public async Task<DeleteDispositionTypeResponse> Handle(DeleteDispositionTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteDispositionTypeResponse()
            {
                Result = true
            };
        }
    }
}
