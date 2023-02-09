/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete DCCConfiguration operation
    /// </summary>
    public class DeleteDCCConfigurationCommandHandler : IRequestHandler<DeleteDCCConfigurationModel, DeleteDCCConfigurationResponse>
    {
        private readonly QSSContext _context;
        private readonly IDCCConfigurationRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteDCCConfigurationCommandHandler(QSSContext context, IDCCConfigurationRepository dCCConfigurationRepository)
        {
            _context = context;
            _repository = dCCConfigurationRepository;
        }

        /// <summary>
        /// Handle the request to Delete DCCConfiguration 
        /// </summary>
        /// <param name="request">Input Delete DCCConfiguration model, <see cref="DeleteDCCConfigurationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteDCCConfigurationResponse"/></returns>
        public async Task<DeleteDCCConfigurationResponse> Handle(DeleteDCCConfigurationModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteDCCConfigurationResponse()
            {
                Result = true
            };
        }
    }
}
