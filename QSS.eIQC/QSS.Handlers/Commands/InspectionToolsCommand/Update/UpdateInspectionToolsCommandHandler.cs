/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Update
{
    /// <summary>
    /// Command Handler for Update InspectionTools operation
    /// </summary>
    public class UpdateInspectionToolsCommandHandler : IRequestHandler<UpdateInspectionToolsModel, InspectionToolsModel>
    {
        private readonly QSSContext _context;
        private readonly IInspectionToolsRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateInspectionToolsCommandHandler(QSSContext context, IInspectionToolsRepository inspectionToolsRepository, IMapper mapper)
        {
            _context = context;
            _repository = inspectionToolsRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update InspectionTools entity
        /// </summary>
        /// <param name="request">Input Update InspectionTools model, <see cref="UpdateInspectionToolsModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated InspectionTools model</returns>
        public async Task<InspectionToolsModel> Handle(UpdateInspectionToolsModel request, CancellationToken cancellationToken)
        {
            var inspectionTools = _mapper.Map<InspectionTools>(request);          

            await _repository.UpdateAsync(inspectionTools, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InspectionToolsModel>(inspectionTools);
        }
    }
}
