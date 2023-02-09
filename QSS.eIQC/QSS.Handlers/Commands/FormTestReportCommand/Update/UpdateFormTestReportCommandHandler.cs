/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormTestReportCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormTestReport operation
    /// </summary>
    public class UpdateFormTestReportCommandHandler : IRequestHandler<UpdateFormTestReportModel, FormTestReportModel>
    {
        private readonly QSSContext _context;
        private readonly IFormTestReportRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormTestReportCommandHandler(QSSContext context, IFormTestReportRepository formTestReportRepository, IMapper mapper)
        {
            _context = context;
            _repository = formTestReportRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormTestReport entity
        /// </summary>
        /// <param name="request">Input Update FormTestReport model, <see cref="UpdateFormTestReportModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormTestReport model</returns>
        public async Task<FormTestReportModel> Handle(UpdateFormTestReportModel request, CancellationToken cancellationToken)
        {
            var formTestReport = _mapper.Map<FormTestReport>(request);          

            await _repository.UpdateAsync(formTestReport, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormTestReportModel>(formTestReport);
        }
    }
}
