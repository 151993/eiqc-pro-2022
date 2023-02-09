/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete DateCode operation
    /// </summary>
    public class DeletePartDateCodeCommandHandler : IRequestHandler<DeletePartDateCodeModel, DeletePartDateCodeResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartDateCodeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartDateCodeCommandHandler(QSSContext context, IPartDateCodeRepository dateCodeRepository)
        {
            _context = context;
            _repository = dateCodeRepository;
        }

        /// <summary>
        /// Handle the request to Delete PartDateCode 
        /// </summary>
        /// <param name="request">Input Delete PartDateCode model, <see cref="DeletePartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartDateCodeResponse"/></returns>
        public async Task<DeletePartDateCodeResponse> Handle(DeletePartDateCodeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartDateCodeResponse()
            {
                Result = true
            };
        }
    }
}
