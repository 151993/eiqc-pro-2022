/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormTestReportCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormTestReport operation
    /// </summary>
    public class DeleteFormTestReportCommandHandler : IRequestHandler<DeleteFormTestReportModel, DeleteFormTestReportResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormTestReportRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormTestReportCommandHandler(QSSContext context, IFormTestReportRepository formTestReportRepository)
        {
            _context = context;
            _repository = formTestReportRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormTestReport 
        /// </summary>
        /// <param name="request">Input Delete FormTestReport model, <see cref="DeleteFormTestReportModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormTestReportResponse"/></returns>
        public async Task<DeleteFormTestReportResponse> Handle(DeleteFormTestReportModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormTestReportResponse()
            {
                Result = true
            };
        }
    }
}
