/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Update
{
    /// <summary>
    /// Command Handler for Update PCCode operation
    /// </summary>
    public class UpdatePCCodeCommandHandler : IRequestHandler<UpdatePCCodeModel, PCCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IPCCodeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePCCodeCommandHandler(QSSContext context, IPCCodeRepository pCCodeRepository, IMapper mapper)
        {
            _context = context;
            _repository = pCCodeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update PCCode entity
        /// </summary>
        /// <param name="request">Input Update PCCode model, <see cref="UpdatePCCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated PCCode model</returns>
        public async Task<PCCodeModel> Handle(UpdatePCCodeModel request, CancellationToken cancellationToken)
        {
            var pCCode = _mapper.Map<PCCode>(request);          

            await _repository.UpdateAsync(pCCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PCCodeModel>(pCCode);
        }
    }
}
