/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Add
{
    /// <summary>
    /// Command Handler for Add GRSSAPResult operation
    /// </summary>
    public class AddGRSSAPResultCommandHandler : IRequestHandler<AddGRSSAPResultModel, GRSSAPResultModel>
    {
        private readonly QSSContext _context;
        private readonly IGRSSAPResultRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddGRSSAPResultCommandHandler(QSSContext context, IGRSSAPResultRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new GRSSAPResult entity
        /// </summary>
        /// <param name="request">Add GRSSAPResult model, <see cref="AddGRSSAPResultModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added GRSSAPResult model</returns>
        public async Task<GRSSAPResultModel> Handle(AddGRSSAPResultModel request, CancellationToken cancellationToken)
        {
            var gRSSAPResult = _mapper.Map<GRSSAPResult>(request);            

            await _repository.AddAsync(gRSSAPResult, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GRSSAPResultModel>(gRSSAPResult);
        }
    }
}
