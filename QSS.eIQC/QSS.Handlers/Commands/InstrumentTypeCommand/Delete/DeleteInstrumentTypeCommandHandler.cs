/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete InstrumentType operation
    /// </summary>
    public class DeleteInstrumentTypeCommandHandler : IRequestHandler<DeleteInstrumentTypeModel, DeleteInstrumentTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IInstrumentTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteInstrumentTypeCommandHandler(QSSContext context, IInstrumentTypeRepository instrumentTypeRepository)
        {
            _context = context;
            _repository = instrumentTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete InstrumentType 
        /// </summary>
        /// <param name="request">Input Delete InstrumentType model, <see cref="DeleteInstrumentTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteInstrumentTypeResponse"/></returns>
        public async Task<DeleteInstrumentTypeResponse> Handle(DeleteInstrumentTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteInstrumentTypeResponse()
            {
                Result = true
            };
        }
    }
}
