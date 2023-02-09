/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.RosettaCommand.Add
{
    /// <summary>
    /// Command Handler for Add Rosetta operation
    /// </summary>
    public class AddRosettaCommandHandler : IRequestHandler<AddRosettaModel, RosettaModel>
    {
        private readonly QSSContext _context;
        private readonly IRosettaRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddRosettaCommandHandler(QSSContext context, IRosettaRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Rosetta entity
        /// </summary>
        /// <param name="request">Add Rosetta model, <see cref="AddRosettaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Rosetta model</returns>
        public async Task<RosettaModel> Handle(AddRosettaModel request, CancellationToken cancellationToken)
        {
            var rosetta = _mapper.Map<Rosetta>(request);            

            await _repository.AddAsync(rosetta, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<RosettaModel>(rosetta);
        }
    }
}
