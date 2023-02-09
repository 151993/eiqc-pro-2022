/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormTestReportCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormTestReport operation
    /// </summary>
    public class AddFormTestReportCommandHandler : IRequestHandler<AddFormTestReportModel, FormTestReportModel>
    {
        private readonly QSSContext _context;
        private readonly IFormTestReportRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormTestReportCommandHandler(QSSContext context, IFormTestReportRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormTestReport entity
        /// </summary>
        /// <param name="request">Add FormTestReport model, <see cref="AddFormTestReportModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormTestReport model</returns>
        public async Task<FormTestReportModel> Handle(AddFormTestReportModel request, CancellationToken cancellationToken)
        {
            var formTestReport = _mapper.Map<FormTestReport>(request);            

            await _repository.AddAsync(formTestReport, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormTestReportModel>(formTestReport);
        }
    }
}
