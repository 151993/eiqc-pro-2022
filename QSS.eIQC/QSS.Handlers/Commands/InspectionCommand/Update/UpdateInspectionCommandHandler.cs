/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Update
{
    /// <summary>
    /// Command Handler for Update Inspection operation
    /// </summary>
    public class UpdateInspectionCommandHandler : IRequestHandler<UpdateInspectionModel, InspectionModel>
    {
        private readonly QSSContext _context;
        private readonly IInspectionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateInspectionCommandHandler(QSSContext context, IInspectionRepository inspectionRepository, IMapper mapper)
        {
            _context = context;
            _repository = inspectionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Inspection entity
        /// </summary>
        /// <param name="request">Input Update Inspection model, <see cref="UpdateInspectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Inspection model</returns>
        public async Task<InspectionModel> Handle(UpdateInspectionModel request, CancellationToken cancellationToken)
        {
            var inspection = _mapper.Map<Inspection>(request);          

            await _repository.UpdateAsync(inspection, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InspectionModel>(inspection);
        }
    }
}
