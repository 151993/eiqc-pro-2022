/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add PartBowTwistParameter operation
    /// </summary>
    public class AddPartInspectionBowTwistParameterCommandHandler : IRequestHandler<AddPartInspectionBowTwistParameterModel, PartInspectionBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionBowTwistParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPartInspectionBowTwistParameterCommandHandler(QSSContext context, IPartInspectionBowTwistParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PartBowTwistParameter entity
        /// </summary>
        /// <param name="request">Add PartBowTwistParameter model, <see cref="AddPartInspectionBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PartBowTwistParameter model</returns>
        public async Task<PartInspectionBowTwistParameterModel> Handle(AddPartInspectionBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var partBowTwistParameter = _mapper.Map<PartInspectionBowTwistParameter>(request);            

            await _repository.AddAsync(partBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartInspectionBowTwistParameterModel>(partBowTwistParameter);
        }
    }
}
