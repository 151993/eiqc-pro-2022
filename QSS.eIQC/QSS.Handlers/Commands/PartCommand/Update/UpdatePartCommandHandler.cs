/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartCommand.Update
{
    /// <summary>
    /// Command Handler for Update Part operation
    /// </summary>
    public class UpdatePartCommandHandler : IRequestHandler<UpdatePartModel, PartModel>
    {
        private readonly QSSContext _context;
        private readonly IPartRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePartCommandHandler(QSSContext context, IPartRepository partRepository, IMapper mapper)
        {
            _context = context;
            _repository = partRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Part entity
        /// </summary>
        /// <param name="request">Input Update Part model, <see cref="UpdatePartModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Part model</returns>
        public async Task<PartModel> Handle(UpdatePartModel request, CancellationToken cancellationToken)
        {
            var part = _mapper.Map<Part>(request);          

            await _repository.UpdateAsync(part, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartModel>(part);
        }
    }
}
