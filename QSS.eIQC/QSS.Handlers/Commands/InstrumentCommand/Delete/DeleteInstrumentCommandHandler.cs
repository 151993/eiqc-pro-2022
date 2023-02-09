/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Instrument operation
    /// </summary>
    public class DeleteInstrumentCommandHandler : IRequestHandler<DeleteInstrumentModel, DeleteInstrumentResponse>
    {
        private readonly QSSContext _context;
        private readonly IInstrumentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteInstrumentCommandHandler(QSSContext context, IInstrumentRepository instrumentRepository)
        {
            _context = context;
            _repository = instrumentRepository;
        }

        /// <summary>
        /// Handle the request to Delete Instrument 
        /// </summary>
        /// <param name="request">Input Delete Instrument model, <see cref="DeleteInstrumentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteInstrumentResponse"/></returns>
        public async Task<DeleteInstrumentResponse> Handle(DeleteInstrumentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteInstrumentResponse()
            {
                Result = true
            };
        }
    }
}
