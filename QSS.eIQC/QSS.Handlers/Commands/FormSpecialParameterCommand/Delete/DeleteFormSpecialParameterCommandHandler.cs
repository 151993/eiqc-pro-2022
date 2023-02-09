/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormSpecialParameter operation
    /// </summary>
    public class DeleteFormSpecialParameterCommandHandler : IRequestHandler<DeleteFormSpecialParameterModel, DeleteFormSpecialParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormSpecialParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormSpecialParameterCommandHandler(QSSContext context, IFormSpecialParameterRepository FormSpecialParameterRepository)
        {
            _context = context;
            _repository = FormSpecialParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormSpecialParameter 
        /// </summary>
        /// <param name="request">Input Delete FormSpecialParameter model, <see cref="DeleteFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormSpecialParameterResponse"/></returns>
        public async Task<DeleteFormSpecialParameterResponse> Handle(DeleteFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormSpecialParameterResponse()
            {
                Result = true
            };
        }
    }
}
