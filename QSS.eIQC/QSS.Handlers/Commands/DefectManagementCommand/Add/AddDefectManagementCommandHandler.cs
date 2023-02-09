/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Add
{
    /// <summary>
    /// Command Handler for Add DefectManagement operation
    /// </summary>
    public class AddDefectManagementCommandHandler : IRequestHandler<AddDefectManagementModel, DefectManagementModel>
    {
        private readonly QSSContext _context;
        private readonly IDefectManagementRepository _repository;
        private readonly IDefectTypeRepository _defectTypeRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddDefectManagementCommandHandler(QSSContext context, IDefectManagementRepository repository, IDefectTypeRepository defectTypeRepository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _defectTypeRepository = defectTypeRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new DefectManagement entity
        /// </summary>
        /// <param name="request">Add DefectManagement model, <see cref="AddDefectManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added DefectManagement model</returns>
        public async Task<DefectManagementModel> Handle(AddDefectManagementModel request, CancellationToken cancellationToken)
        {
            var certificateType = _mapper.Map<DefectManagement>(request);

            _defectTypeRepository.AddDefectTypes(certificateType, request.AddedDefectTypes);

            await _repository.AddAsync(certificateType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DefectManagementModel>(certificateType);
        }
    }
}
