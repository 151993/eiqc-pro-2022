/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormFunParaCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormFunPara operation
    /// </summary>
    public class DeleteFormFunParaCommandHandler : IRequestHandler<DeleteFormFunParaModel, DeleteFormFunParaResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormFunParaRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormFunParaCommandHandler(QSSContext context, IFormFunParaRepository formFunParaRepository)
        {
            _context = context;
            _repository = formFunParaRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormFunPara 
        /// </summary>
        /// <param name="request">Input Delete FormFunPara model, <see cref="DeleteFormFunParaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormFunParaResponse"/></returns>
        public async Task<DeleteFormFunParaResponse> Handle(DeleteFormFunParaModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormFunParaResponse()
            {
                Result = true
            };
        }
    }
}
