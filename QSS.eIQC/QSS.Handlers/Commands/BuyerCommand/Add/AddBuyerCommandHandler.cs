/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Add
{
    /// <summary>
    /// Command Handler for Add Buyer operation
    /// </summary>
    public class AddBuyerCommandHandler : IRequestHandler<AddBuyerModel, BuyerModel>
    {
        private readonly QSSContext _context;
        private readonly IBuyerRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddBuyerCommandHandler(QSSContext context, IBuyerRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Buyer entity
        /// </summary>
        /// <param name="request">Add Buyer model, <see cref="AddBuyerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Buyer model</returns>
        public async Task<BuyerModel> Handle(AddBuyerModel request, CancellationToken cancellationToken)
        {
            var buyer = _mapper.Map<Buyer>(request);            

            await _repository.AddAsync(buyer, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<BuyerModel>(buyer);
        }
    }
}
