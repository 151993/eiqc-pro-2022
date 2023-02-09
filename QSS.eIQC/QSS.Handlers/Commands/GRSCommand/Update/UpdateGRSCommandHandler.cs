/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GRSCommand.Update
{
    /// <summary>
    /// Command Handler for Update GRS operation
    /// </summary>
    public class UpdateGRSCommandHandler : IRequestHandler<UpdateGRSModel, GRSModel>
    {
        private readonly QSSContext _context;
        private readonly IGRSRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateGRSCommandHandler(QSSContext context, IGRSRepository gRSRepository, IMapper mapper)
        {
            _context = context;
            _repository = gRSRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update GRS entity
        /// </summary>
        /// <param name="request">Input Update GRS model, <see cref="UpdateGRSModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated GRS model</returns>
        public async Task<GRSModel> Handle(UpdateGRSModel request, CancellationToken cancellationToken)
        {
            var gRS = _mapper.Map<GRS>(request);          

            await _repository.UpdateAsync(gRS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GRSModel>(gRS);
        }
    }
}
