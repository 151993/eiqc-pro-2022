/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormBowTwistParameter operation
    /// </summary>
    public class AddFormBowTwistParameterCommandHandler : IRequestHandler<AddFormBowTwistParameterModel, FormBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormBowTwistParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormBowTwistParameterCommandHandler(QSSContext context, IFormBowTwistParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormBowTwistParameter entity
        /// </summary>
        /// <param name="request">Add FormBowTwistParameter model, <see cref="AddFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormBowTwistParameter model</returns>
        public async Task<FormBowTwistParameterModel> Handle(AddFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var formBowTwistParameter = _mapper.Map<FormBowTwistParameter>(request);            

            await _repository.AddAsync(formBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormBowTwistParameterModel>(formBowTwistParameter);
        }
    }
}
