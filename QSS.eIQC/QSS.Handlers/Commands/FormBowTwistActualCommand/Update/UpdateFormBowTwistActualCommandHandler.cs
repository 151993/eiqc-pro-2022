/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormBowTwistActual operation
    /// </summary>
    public class UpdateFormBowTwistActualCommandHandler : IRequestHandler<UpdateFormBowTwistActualModel, FormBowTwistActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormBowTwistActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormBowTwistActualCommandHandler(QSSContext context, IFormBowTwistActualRepository formBowTwistActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = formBowTwistActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormBowTwistActual entity
        /// </summary>
        /// <param name="request">Input Update FormBowTwistActual model, <see cref="UpdateFormBowTwistActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormBowTwistActual model</returns>
        public async Task<FormBowTwistActualModel> Handle(UpdateFormBowTwistActualModel request, CancellationToken cancellationToken)
        {
            var formBowTwistActual = _mapper.Map<FormBowTwistActual>(request);          

            await _repository.UpdateAsync(formBowTwistActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormBowTwistActualModel>(formBowTwistActual);
        }
    }
}
