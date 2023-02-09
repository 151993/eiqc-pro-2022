/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.CTParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete CTParameter operation
    /// </summary>
    public class DeleteCTParameterCommandHandler : IRequestHandler<DeleteCTParameterModel, DeleteCTParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly ICTParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCTParameterCommandHandler(QSSContext context, ICTParameterRepository cTParameterRepository)
        {
            _context = context;
            _repository = cTParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete CTParameter 
        /// </summary>
        /// <param name="request">Input Delete CTParameter model, <see cref="DeleteCTParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCTParameterResponse"/></returns>
        public async Task<DeleteCTParameterResponse> Handle(DeleteCTParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteCTParameterResponse()
            {
                Result = true
            };
        }
    }
}
