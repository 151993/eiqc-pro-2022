/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Update
{
    /// <summary>
    /// Command Handler for Update ReceiveGoodsInfo operation
    /// </summary>
    public class UpdateReceiveGoodsInfoCommandHandler : IRequestHandler<UpdateReceiveGoodsInfoModel, ReceiveGoodsInfoModel>
    {
        private readonly QSSContext _context;
        private readonly IReceiveGoodsInfoRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateReceiveGoodsInfoCommandHandler(QSSContext context, IReceiveGoodsInfoRepository receiveGoodsInfoRepository, IMapper mapper)
        {
            _context = context;
            _repository = receiveGoodsInfoRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update ReceiveGoodsInfo entity
        /// </summary>
        /// <param name="request">Input Update ReceiveGoodsInfo model, <see cref="UpdateReceiveGoodsInfoModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated ReceiveGoodsInfo model</returns>
        public async Task<ReceiveGoodsInfoModel> Handle(UpdateReceiveGoodsInfoModel request, CancellationToken cancellationToken)
        {
            var receiveGoodsInfo = _mapper.Map<ReceiveGoodsInfo>(request);          

            await _repository.UpdateAsync(receiveGoodsInfo, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ReceiveGoodsInfoModel>(receiveGoodsInfo);
        }
    }
}
