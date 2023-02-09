/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Update
{
    /// <summary>
    /// Command Handler for Update GoodsReceiveUser operation
    /// </summary>
    public class UpdateGoodsReceiveUserCommandHandler : IRequestHandler<UpdateGoodsReceiveUserModel, GoodsReceiveUserModel>
    {
        private readonly QSSContext _context;
        private readonly IGoodsReceiveUserRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateGoodsReceiveUserCommandHandler(QSSContext context, IGoodsReceiveUserRepository goodsReceiveUserRepository, IMapper mapper)
        {
            _context = context;
            _repository = goodsReceiveUserRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update GoodsReceiveUser entity
        /// </summary>
        /// <param name="request">Input Update GoodsReceiveUser model, <see cref="UpdateGoodsReceiveUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated GoodsReceiveUser model</returns>
        public async Task<GoodsReceiveUserModel> Handle(UpdateGoodsReceiveUserModel request, CancellationToken cancellationToken)
        {
            var goodsReceiveUser = _mapper.Map<GoodsReceiveUser>(request);          

            await _repository.UpdateAsync(goodsReceiveUser, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GoodsReceiveUserModel>(goodsReceiveUser);
        }
    }
}
