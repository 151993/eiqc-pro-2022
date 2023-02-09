/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add
{
    /// <summary>
    /// Command Handler for Add PartDimension operation
    /// </summary>
    public class AddPartDimensionCommandHandler : IRequestHandler<AddPartDimensionModel, PartDimensionModel>
    {
        private readonly QSSContext _context;
        private readonly IPartDimensionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPartDimensionCommandHandler(QSSContext context, IPartDimensionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PartDimension entity
        /// </summary>
        /// <param name="request">Add PartDimension model, <see cref="AddPartDimensionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PartDimension model</returns>
        public async Task<PartDimensionModel> Handle(AddPartDimensionModel request, CancellationToken cancellationToken)
        {
            var partDimension = _mapper.Map<PartDimension>(request);            

            await _repository.AddAsync(partDimension, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartDimensionModel>(partDimension);
        }
    }
}
