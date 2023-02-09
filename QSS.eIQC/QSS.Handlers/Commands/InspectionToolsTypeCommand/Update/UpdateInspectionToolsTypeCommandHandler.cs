/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Update
{
    /// <summary>
    /// Command Handler for Update InspectionToolsType operation
    /// </summary>
    public class UpdateInspectionToolsTypeCommandHandler : IRequestHandler<UpdateInspectionToolsTypeModel, InspectionToolsTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IInspectionToolsTypeRepository _repository;      
        private readonly IMapper _mapper;
        private readonly IInspectionToolsTypePcCodeRepository _inspectionToolsTypePcCodeRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateInspectionToolsTypeCommandHandler(QSSContext context, IInspectionToolsTypeRepository inspectionToolsTypeRepository, IMapper mapper, IInspectionToolsTypePcCodeRepository inspectionToolsTypePcCodeRepository)
        {
            _context = context;
            _repository = inspectionToolsTypeRepository;            
            _mapper = mapper;
            _inspectionToolsTypePcCodeRepository = inspectionToolsTypePcCodeRepository;
        }

        /// <summary>
        /// Validates the input model and Update InspectionToolsType entity
        /// </summary>
        /// <param name="request">Input Update InspectionToolsType model, <see cref="UpdateInspectionToolsTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated InspectionToolsType model</returns>
        public async Task<InspectionToolsTypeModel> Handle(UpdateInspectionToolsTypeModel request, CancellationToken cancellationToken)
        {
            var inspectionToolsType = _mapper.Map<InspectionToolsType>(request);

            _inspectionToolsTypePcCodeRepository.AddInspectionToolsTypePcCode(inspectionToolsType, request.AddedPcCodeIds);

            _inspectionToolsTypePcCodeRepository.RemoveInspectionToolsTypePcCode(inspectionToolsType.Id, request.RemovedPcCodeIds);

            await _repository.UpdateAsync(inspectionToolsType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InspectionToolsTypeModel>(inspectionToolsType);
        }
    }
}
