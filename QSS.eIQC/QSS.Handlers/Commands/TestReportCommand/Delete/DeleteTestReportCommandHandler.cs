/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete TestReport operation
    /// </summary>
    public class DeleteTestReportCommandHandler : IRequestHandler<DeleteTestReportModel, DeleteTestReportResponse>
    {
        private readonly QSSContext _context;
        private readonly ITestReportRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteTestReportCommandHandler(QSSContext context, ITestReportRepository testReportRepository)
        {
            _context = context;
            _repository = testReportRepository;
        }

        /// <summary>
        /// Handle the request to Delete TestReport 
        /// </summary>
        /// <param name="request">Input Delete TestReport model, <see cref="DeleteTestReportModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteTestReportResponse"/></returns>
        public async Task<DeleteTestReportResponse> Handle(DeleteTestReportModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteTestReportResponse()
            {
                Result = true
            };
        }
    }
}
