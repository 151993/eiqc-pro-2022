/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMicroSection operation
    /// </summary>
    public class DeleteFormMicroSectionCommandHandler : IRequestHandler<DeleteFormMicroSectionModel, DeleteFormMicroSectionResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMicroSectionCommandHandler(QSSContext context, IFormMicroSectionRepository formMicroSectionRepository)
        {
            _context = context;
            _repository = formMicroSectionRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMicroSection 
        /// </summary>
        /// <param name="request">Input Delete FormMicroSection model, <see cref="DeleteFormMicroSectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMicroSectionResponse"/></returns>
        public async Task<DeleteFormMicroSectionResponse> Handle(DeleteFormMicroSectionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMicroSectionResponse()
            {
                Result = true
            };
        }
    }
}
