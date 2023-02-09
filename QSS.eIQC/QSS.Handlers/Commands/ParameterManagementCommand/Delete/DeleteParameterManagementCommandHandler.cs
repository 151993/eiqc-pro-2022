/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete ParameterManagement operation
    /// </summary>
    public class DeleteParameterManagementCommandHandler : IRequestHandler<DeleteParameterManagementModel, DeleteParameterManagementResponse>
    {
        private readonly QSSContext _context;
        private readonly IParameterManagementRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// /// <param name="parameterManagementRepository">Injected instance of parameterManagementRepository on runtime, <see cref="IParameterManagementRepository"/></param>
        public DeleteParameterManagementCommandHandler(QSSContext context, IParameterManagementRepository parameterManagementRepository)
        {
            _context = context;
            _repository = parameterManagementRepository;
        }

        /// <summary>
        /// Handle the request to Delete ParameterManagement 
        /// </summary>
        /// <param name="request">Input Delete ParameterManagement model, <see cref="DeleteParameterManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteParameterManagementResponse"/></returns>
        public async Task<DeleteParameterManagementResponse> Handle(DeleteParameterManagementModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteParameterManagementResponse()
            {
                Result = true
            };
        }
    }
}
