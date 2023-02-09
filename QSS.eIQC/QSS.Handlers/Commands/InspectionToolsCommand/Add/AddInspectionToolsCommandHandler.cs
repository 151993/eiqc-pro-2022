/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Add
{
    /// <summary>
    /// Command Handler for Add InspectionTools operation
    /// </summary>
    public class AddInspectionToolsCommandHandler : IRequestHandler<AddInspectionToolsModel, InspectionToolsModel>
    {
        private readonly QSSContext _context;
        private readonly IInspectionToolsRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddInspectionToolsCommandHandler(QSSContext context, IInspectionToolsRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new InspectionTools entity
        /// </summary>
        /// <param name="request">Add InspectionTools model, <see cref="AddInspectionToolsModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added InspectionTools model</returns>
        public async Task<InspectionToolsModel> Handle(AddInspectionToolsModel request, CancellationToken cancellationToken)
        {
            var inspectionTools = _mapper.Map<InspectionTools>(request);            

            await _repository.AddAsync(inspectionTools, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InspectionToolsModel>(inspectionTools);
        }
    }
}
