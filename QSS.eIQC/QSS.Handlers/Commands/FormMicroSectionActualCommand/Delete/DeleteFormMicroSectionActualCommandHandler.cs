/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMicroSectionActual operation
    /// </summary>
    public class DeleteFormMicroSectionActualCommandHandler : IRequestHandler<DeleteFormMicroSectionActualModel, DeleteFormMicroSectionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMicroSectionActualCommandHandler(QSSContext context, IFormMicroSectionActualRepository formMicroSectionActualRepository)
        {
            _context = context;
            _repository = formMicroSectionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMicroSectionActual 
        /// </summary>
        /// <param name="request">Input Delete FormMicroSectionActual model, <see cref="DeleteFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMicroSectionActualResponse"/></returns>
        public async Task<DeleteFormMicroSectionActualResponse> Handle(DeleteFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMicroSectionActualResponse()
            {
                Result = true
            };
        }
    }
}
