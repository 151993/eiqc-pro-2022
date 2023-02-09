/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add InspectionToolsType operation
    /// </summary>
    public class AddInspectionToolsTypeCommandHandler : IRequestHandler<AddInspectionToolsTypeModel, InspectionToolsTypeModel>
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
        public AddInspectionToolsTypeCommandHandler(QSSContext context, IInspectionToolsTypeRepository repository, IMapper mapper, IInspectionToolsTypePcCodeRepository inspectionToolsTypePcCodeRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _inspectionToolsTypePcCodeRepository = inspectionToolsTypePcCodeRepository;
        }

        /// <summary>
        /// Validates the input model and Add new InspectionToolsType entity
        /// </summary>
        /// <param name="request">Add InspectionToolsType model, <see cref="AddInspectionToolsTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added InspectionToolsType model</returns>
        public async Task<InspectionToolsTypeModel> Handle(AddInspectionToolsTypeModel request, CancellationToken cancellationToken)
        {
            var inspectionToolsType = _mapper.Map<InspectionToolsType>(request);

            _inspectionToolsTypePcCodeRepository.AddInspectionToolsTypePcCode(inspectionToolsType, request.AddedPcCodeIds);

            await _repository.AddAsync(inspectionToolsType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InspectionToolsTypeModel>(inspectionToolsType);
        }
    }
}
