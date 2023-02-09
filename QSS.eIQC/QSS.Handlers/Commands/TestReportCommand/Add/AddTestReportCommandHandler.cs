/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Add
{
    /// <summary>
    /// Command Handler for Add TestReport operation
    /// </summary>
    public class AddTestReportCommandHandler : IRequestHandler<AddTestReportModel, TestReportModel>
    {
        private readonly QSSContext _context;
        private readonly ITestReportRepository _repository;
        private readonly IMapper _mapper;
        private readonly ITestReportCommodityRepository _testReportCommodityRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddTestReportCommandHandler(QSSContext context, ITestReportRepository repository, IMapper mapper, ITestReportCommodityRepository testReportCommodityRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _testReportCommodityRepository = testReportCommodityRepository;
        }

        /// <summary>
        /// Validates the input model and Add new TestReport entity
        /// </summary>
        /// <param name="request">Add TestReport model, <see cref="AddTestReportModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added TestReport model</returns>
        public async Task<TestReportModel> Handle(AddTestReportModel request, CancellationToken cancellationToken)
        {
            var testReport = _mapper.Map<TestReport>(request);

            _testReportCommodityRepository.AddTestReportCommodities(testReport, request.AddedCommodityIds);

            await _repository.AddAsync(testReport, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<TestReportModel>(testReport);
        }
    }
}
