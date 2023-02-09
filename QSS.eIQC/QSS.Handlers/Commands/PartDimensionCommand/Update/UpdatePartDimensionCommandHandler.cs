/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartDimensionCommand.Update
{
    /// <summary>
    /// Command Handler for Update PartDimension operation
    /// </summary>
    public class UpdatePartDimensionCommandHandler : IRequestHandler<UpdatePartDimensionModel, PartDimensionModel>
    {
        private readonly QSSContext _context;
        private readonly IPartDimensionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePartDimensionCommandHandler(QSSContext context, IPartDimensionRepository partDimensionRepository, IMapper mapper)
        {
            _context = context;
            _repository = partDimensionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update PartDimension entity
        /// </summary>
        /// <param name="request">Input Update PartDimension model, <see cref="UpdatePartDimensionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated PartDimension model</returns>
        public async Task<PartDimensionModel> Handle(UpdatePartDimensionModel request, CancellationToken cancellationToken)
        {
            var partDimension = _mapper.Map<PartDimension>(request);          

            await _repository.UpdateAsync(partDimension, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartDimensionModel>(partDimension);
        }
    }
}
