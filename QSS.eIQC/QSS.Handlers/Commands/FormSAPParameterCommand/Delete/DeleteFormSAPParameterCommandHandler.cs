/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormSAPParameter operation
    /// </summary>
    public class DeleteFormSAPParameterCommandHandler : IRequestHandler<DeleteFormSAPParameterModel, DeleteFormSAPParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormSAPParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormSAPParameterCommandHandler(QSSContext context, IFormSAPParameterRepository FormSAPParameterRepository)
        {
            _context = context;
            _repository = FormSAPParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormSAPParameter 
        /// </summary>
        /// <param name="request">Input Delete FormSAPParameter model, <see cref="DeleteFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormSAPParameterResponse"/></returns>
        public async Task<DeleteFormSAPParameterResponse> Handle(DeleteFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormSAPParameterResponse()
            {
                Result = true
            };
        }
    }
}
