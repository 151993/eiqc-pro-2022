/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Update
{
    /// <summary>
    /// Command Handler for Update GRSSAPResult operation
    /// </summary>
    public class UpdateGRSSAPResultCommandHandler : IRequestHandler<UpdateGRSSAPResultModel, GRSSAPResultModel>
    {
        private readonly QSSContext _context;
        private readonly IGRSSAPResultRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateGRSSAPResultCommandHandler(QSSContext context, IGRSSAPResultRepository gRSSAPResultRepository, IMapper mapper)
        {
            _context = context;
            _repository = gRSSAPResultRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update GRSSAPResult entity
        /// </summary>
        /// <param name="request">Input Update GRSSAPResult model, <see cref="UpdateGRSSAPResultModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated GRSSAPResult model</returns>
        public async Task<GRSSAPResultModel> Handle(UpdateGRSSAPResultModel request, CancellationToken cancellationToken)
        {
            var gRSSAPResult = _mapper.Map<GRSSAPResult>(request);          

            await _repository.UpdateAsync(gRSSAPResult, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GRSSAPResultModel>(gRSSAPResult);
        }
    }
}
