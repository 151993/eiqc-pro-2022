/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Update
{
    /// <summary>
    /// Command Handler for Update Buyer operation
    /// </summary>
    public class UpdateBuyerCommandHandler : IRequestHandler<UpdateBuyerModel, BuyerModel>
    {
        private readonly QSSContext _context;
        private readonly IBuyerRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateBuyerCommandHandler(QSSContext context, IBuyerRepository buyerRepository, IMapper mapper)
        {
            _context = context;
            _repository = buyerRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Buyer entity
        /// </summary>
        /// <param name="request">Input Update Buyer model, <see cref="UpdateBuyerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Buyer model</returns>
        public async Task<BuyerModel> Handle(UpdateBuyerModel request, CancellationToken cancellationToken)
        {
            var buyer = _mapper.Map<Buyer>(request);          

            await _repository.UpdateAsync(buyer, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<BuyerModel>(buyer);
        }
    }
}
