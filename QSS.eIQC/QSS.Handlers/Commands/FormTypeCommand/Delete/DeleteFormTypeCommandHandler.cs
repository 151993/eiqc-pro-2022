/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormType operation
    /// </summary>
    public class DeleteFormTypeCommandHandler : IRequestHandler<DeleteFormTypeModel, DeleteFormTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormTypeCommandHandler(QSSContext context, IFormTypeRepository formTypeRepository)
        {
            _context = context;
            _repository = formTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormType 
        /// </summary>
        /// <param name="request">Input Delete FormType model, <see cref="DeleteFormTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormTypeResponse"/></returns>
        public async Task<DeleteFormTypeResponse> Handle(DeleteFormTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormTypeResponse()
            {
                Result = true
            };
        }
    }
}
