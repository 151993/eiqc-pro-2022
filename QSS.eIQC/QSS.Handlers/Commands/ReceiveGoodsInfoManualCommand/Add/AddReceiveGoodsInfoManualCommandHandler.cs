/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Add
{
    /// <summary>
    /// Command Handler for Add ReceiveGoodsInfoManual operation
    /// </summary>
    public class AddReceiveGoodsInfoManualCommandHandler : IRequestHandler<AddReceiveGoodsInfoManualModel, ReceiveGoodsInfoManualModel>
    {
        private readonly QSSContext _context;
        private readonly IReceiveGoodsInfoManualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddReceiveGoodsInfoManualCommandHandler(QSSContext context, IReceiveGoodsInfoManualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new ReceiveGoodsInfoManual entity
        /// </summary>
        /// <param name="request">Add ReceiveGoodsInfoManual model, <see cref="AddReceiveGoodsInfoManualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ReceiveGoodsInfoManual model</returns>
        public async Task<ReceiveGoodsInfoManualModel> Handle(AddReceiveGoodsInfoManualModel request, CancellationToken cancellationToken)
        {
            var receiveGoodsInfoManual = _mapper.Map<ReceiveGoodsInfoManual>(request);            

            await _repository.AddAsync(receiveGoodsInfoManual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ReceiveGoodsInfoManualModel>(receiveGoodsInfoManual);
        }
    }
}
