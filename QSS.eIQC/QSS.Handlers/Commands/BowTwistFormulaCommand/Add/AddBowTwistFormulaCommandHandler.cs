/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add
{
    /// <summary>
    /// Command Handler for Add BowTwistFormula operation
    /// </summary>
    public class AddBowTwistFormulaCommandHandler : IRequestHandler<AddBowTwistFormulaModel, BowTwistFormulaModel>
    {
        private readonly QSSContext _context;
        private readonly IBowTwistFormulaRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddBowTwistFormulaCommandHandler(QSSContext context, IBowTwistFormulaRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new BowTwistFormula entity
        /// </summary>
        /// <param name="request">Add BowTwistFormula model, <see cref="AddBowTwistFormulaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added BowTwistFormula model</returns>
        public async Task<BowTwistFormulaModel> Handle(AddBowTwistFormulaModel request, CancellationToken cancellationToken)
        {
            var bowTwistFormula = _mapper.Map<BowTwistFormula>(request);            

            await _repository.AddAsync(bowTwistFormula, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<BowTwistFormulaModel>(bowTwistFormula);
        }
    }
}
