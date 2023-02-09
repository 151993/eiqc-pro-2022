/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Add
{
    /// <summary>
    /// Command Handler for Add ReceiveGoodsInfo operation
    /// </summary>
    public class AddReceiveGoodsInfoCommandHandler : IRequestHandler<AddReceiveGoodsInfoModel, ReceiveGoodsInfoModel>
    {
        private readonly QSSContext _context;
        private readonly IReceiveGoodsInfoRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddReceiveGoodsInfoCommandHandler(QSSContext context, IReceiveGoodsInfoRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new ReceiveGoodsInfo entity
        /// </summary>
        /// <param name="request">Add ReceiveGoodsInfo model, <see cref="AddReceiveGoodsInfoModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ReceiveGoodsInfo model</returns>
        public async Task<ReceiveGoodsInfoModel> Handle(AddReceiveGoodsInfoModel request, CancellationToken cancellationToken)
        {
            var receiveGoodsInfo = _mapper.Map<ReceiveGoodsInfo>(request);            

            await _repository.AddAsync(receiveGoodsInfo, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ReceiveGoodsInfoModel>(receiveGoodsInfo);
        }
    }
}
