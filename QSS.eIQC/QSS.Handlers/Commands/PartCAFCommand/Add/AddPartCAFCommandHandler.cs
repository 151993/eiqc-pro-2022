/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Add
{
    /// <summary>
    /// Command Handler for Add PartCAF operation
    /// </summary>
    public class AddPartCAFCommandHandler : IRequestHandler<AddPartCAFModel, PartCAFModel>
    {
        private readonly QSSContext _context;
        private readonly IPartCAFRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPartCAFCommandHandler(QSSContext context, IPartCAFRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PartCAF entity
        /// </summary>
        /// <param name="request">Add PartCAF model, <see cref="AddPartCAFModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PartCAF model</returns>
        public async Task<PartCAFModel> Handle(AddPartCAFModel request, CancellationToken cancellationToken)
        {
            var partCAF = _mapper.Map<PartCAF>(request);            

            await _repository.AddAsync(partCAF, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartCAFModel>(partCAF);
        }
    }
}
