/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update PartBowTwistParameter operation
    /// </summary>
    public class UpdatePartInspectionBowTwistParameterCommandHandler : IRequestHandler<UpdatePartInspectionBowTwistParameterModel, PartInspectionBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionBowTwistParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePartInspectionBowTwistParameterCommandHandler(QSSContext context, IPartInspectionBowTwistParameterRepository partBowTwistParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = partBowTwistParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update PartBowTwistParameter entity
        /// </summary>
        /// <param name="request">Input Update PartBowTwistParameter model, <see cref="UpdatePartInspectionBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated PartBowTwistParameter model</returns>
        public async Task<PartInspectionBowTwistParameterModel> Handle(UpdatePartInspectionBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var partBowTwistParameter = _mapper.Map<PartInspectionBowTwistParameter>(request);          

            await _repository.UpdateAsync(partBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartInspectionBowTwistParameterModel>(partBowTwistParameter);
        }
    }
}
