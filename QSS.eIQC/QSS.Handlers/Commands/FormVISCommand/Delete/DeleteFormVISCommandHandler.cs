/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormVIS operation
    /// </summary>
    public class DeleteFormVISCommandHandler : IRequestHandler<DeleteFormVISModel, DeleteFormVISResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormVISRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormVISCommandHandler(QSSContext context, IFormVISRepository formVISRepository)
        {
            _context = context;
            _repository = formVISRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormVIS 
        /// </summary>
        /// <param name="request">Input Delete FormVIS model, <see cref="DeleteFormVISModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormVISResponse"/></returns>
        public async Task<DeleteFormVISResponse> Handle(DeleteFormVISModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormVISResponse()
            {
                Result = true
            };
        }
    }
}
