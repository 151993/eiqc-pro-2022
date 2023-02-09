/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Update
{
    /// <summary>
    /// Command Handler for Update DefectManagement operation
    /// </summary>
    public class UpdateDefectManagementCommandHandler : IRequestHandler<UpdateDefectManagementModel, DefectManagementModel>
    {
        private readonly QSSContext _context;
        private readonly IDefectManagementRepository _repository;
        private readonly IDefectTypeRepository _defectTypeParameterRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateDefectManagementCommandHandler(QSSContext context, IDefectManagementRepository defectManagementRepository, IDefectTypeRepository defectTypeParameterRepository,IMapper mapper)
        {
            _context = context;
            _repository = defectManagementRepository;
            _defectTypeParameterRepository = defectTypeParameterRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update DefectManagement entity
        /// </summary>
        /// <param name="request">Input Update DefectManagement model, <see cref="UpdateDefectManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated DefectManagement model</returns>
        public async Task<DefectManagementModel> Handle(UpdateDefectManagementModel request, CancellationToken cancellationToken)
        {
            var defectManagement = _mapper.Map<DefectManagement>(request);

            _defectTypeParameterRepository.AddDefectTypes(defectManagement, request.AddedDefectTypes);

            _defectTypeParameterRepository.RemoveDefectTypes(defectManagement.Id, request.RemovedDefectTypes);

            await _repository.UpdateAsync(defectManagement, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DefectManagementModel>(defectManagement);
        }
    }
}
