/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete ParameterTypeCode operation
    /// </summary>
    public class DeleteParameterTypeCodeCommandHandler : IRequestHandler<DeleteParameterTypeCodeModel, DeleteParameterTypeCodeResponse>
    {
        private readonly QSSContext _context;
        private readonly IParameterTypeCodeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteParameterTypeCodeCommandHandler(QSSContext context, IParameterTypeCodeRepository parameterTypeCodeRepository)
        {
            _context = context;
            _repository = parameterTypeCodeRepository;
        }

        /// <summary>
        /// Handle the request to Delete ParameterTypeCode 
        /// </summary>
        /// <param name="request">Input Delete ParameterTypeCode model, <see cref="DeleteParameterTypeCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteParameterTypeCodeResponse"/></returns>
        public async Task<DeleteParameterTypeCodeResponse> Handle(DeleteParameterTypeCodeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteParameterTypeCodeResponse()
            {
                Result = true
            };
        }
    }
}
