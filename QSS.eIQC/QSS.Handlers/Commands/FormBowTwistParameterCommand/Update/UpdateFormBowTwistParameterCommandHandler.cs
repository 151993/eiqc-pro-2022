/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormBowTwistParameter operation
    /// </summary>
    public class UpdateFormBowTwistParameterCommandHandler : IRequestHandler<UpdateFormBowTwistParameterModel, FormBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormBowTwistParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormBowTwistParameterCommandHandler(QSSContext context, IFormBowTwistParameterRepository formBowTwistParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = formBowTwistParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormBowTwistParameter entity
        /// </summary>
        /// <param name="request">Input Update FormBowTwistParameter model, <see cref="UpdateFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormBowTwistParameter model</returns>
        public async Task<FormBowTwistParameterModel> Handle(UpdateFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var formBowTwistParameter = _mapper.Map<FormBowTwistParameter>(request);          

            await _repository.UpdateAsync(formBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormBowTwistParameterModel>(formBowTwistParameter);
        }
    }
}
