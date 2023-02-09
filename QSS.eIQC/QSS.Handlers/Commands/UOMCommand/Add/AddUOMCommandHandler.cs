/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Add
{
    /// <summary>
    /// Command Handler for Add UOM operation
    /// </summary>
    public class AddUOMCommandHandler : IRequestHandler<AddUOMModel, UOMModel>
    {
        private readonly QSSContext _context;
        private readonly IUOMRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddUOMCommandHandler(QSSContext context, IUOMRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new UOM entity
        /// </summary>
        /// <param name="request">Add UOM model, <see cref="AddUOMModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added UOM model</returns>
        public async Task<UOMModel> Handle(AddUOMModel request, CancellationToken cancellationToken)
        {
            var uOM = _mapper.Map<UOM>(request);            

            await _repository.AddAsync(uOM, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<UOMModel>(uOM);
        }
    }
}
