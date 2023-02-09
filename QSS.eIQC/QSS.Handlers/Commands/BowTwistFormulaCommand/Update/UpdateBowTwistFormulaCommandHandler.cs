/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update
{
    /// <summary>
    /// Command Handler for Update BowTwistFormula operation
    /// </summary>
    public class UpdateBowTwistFormulaCommandHandler : IRequestHandler<UpdateBowTwistFormulaModel, BowTwistFormulaModel>
    {
        private readonly QSSContext _context;
        private readonly IBowTwistFormulaRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateBowTwistFormulaCommandHandler(QSSContext context, IBowTwistFormulaRepository bowTwistFormulaRepository, IMapper mapper)
        {
            _context = context;
            _repository = bowTwistFormulaRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update BowTwistFormula entity
        /// </summary>
        /// <param name="request">Input Update BowTwistFormula model, <see cref="UpdateBowTwistFormulaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated BowTwistFormula model</returns>
        public async Task<BowTwistFormulaModel> Handle(UpdateBowTwistFormulaModel request, CancellationToken cancellationToken)
        {
            var bowTwistFormula = _mapper.Map<BowTwistFormula>(request);          

            await _repository.UpdateAsync(bowTwistFormula, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<BowTwistFormulaModel>(bowTwistFormula);
        }
    }
}
