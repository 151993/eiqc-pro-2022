/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete ParameterType operation
    /// </summary>
    public class DeleteParameterTypeCommandHandler : IRequestHandler<DeleteParameterTypeModel, DeleteParameterTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IParameterTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteParameterTypeCommandHandler(QSSContext context, IParameterTypeRepository parameterTypeRepository)
        {
            _context = context;
            _repository = parameterTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete ParameterType 
        /// </summary>
        /// <param name="request">Input Delete ParameterType model, <see cref="DeleteParameterTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteParameterTypeResponse"/></returns>
        public async Task<DeleteParameterTypeResponse> Handle(DeleteParameterTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteParameterTypeResponse()
            {
                Result = true
            };
        }
    }
}
