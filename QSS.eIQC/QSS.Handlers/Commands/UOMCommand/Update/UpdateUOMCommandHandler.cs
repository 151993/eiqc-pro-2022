/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Update
{
    /// <summary>
    /// Command Handler for Update UOM operation
    /// </summary>
    public class UpdateUOMCommandHandler : IRequestHandler<UpdateUOMModel, UOMModel>
    {
        private readonly QSSContext _context;
        private readonly IUOMRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateUOMCommandHandler(QSSContext context, IUOMRepository uOMRepository, IMapper mapper)
        {
            _context = context;
            _repository = uOMRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update UOM entity
        /// </summary>
        /// <param name="request">Input Update UOM model, <see cref="UpdateUOMModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated UOM model</returns>
        public async Task<UOMModel> Handle(UpdateUOMModel request, CancellationToken cancellationToken)
        {
            var uOM = _mapper.Map<UOM>(request);          

            await _repository.UpdateAsync(uOM, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<UOMModel>(uOM);
        }
    }
}
