/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Add
{
    /// <summary>
    /// Command Handler for Add PCCode operation
    /// </summary>
    public class AddPCCodeCommandHandler : IRequestHandler<AddPCCodeModel, PCCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IPCCodeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPCCodeCommandHandler(QSSContext context, IPCCodeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PCCode entity
        /// </summary>
        /// <param name="request">Add PCCode model, <see cref="AddPCCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PCCode model</returns>
        public async Task<PCCodeModel> Handle(AddPCCodeModel request, CancellationToken cancellationToken)
        {
            var pCCode = _mapper.Map<PCCode>(request);            

            await _repository.AddAsync(pCCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PCCodeModel>(pCCode);
        }
    }
}
