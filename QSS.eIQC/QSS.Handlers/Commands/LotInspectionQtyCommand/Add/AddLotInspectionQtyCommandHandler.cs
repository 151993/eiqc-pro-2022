/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Add
{
    /// <summary>
    /// Command Handler for Add LotInspectionQty operation
    /// </summary>
    public class AddLotInspectionQtyCommandHandler : IRequestHandler<AddLotInspectionQtyModel, LotInspectionQtyModel>
    {
        private readonly QSSContext _context;
        private readonly ILotInspectionQtyRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddLotInspectionQtyCommandHandler(QSSContext context, ILotInspectionQtyRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new LotInspectionQty entity
        /// </summary>
        /// <param name="request">Add LotInspectionQty model, <see cref="AddLotInspectionQtyModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added LotInspectionQty model</returns>
        public async Task<LotInspectionQtyModel> Handle(AddLotInspectionQtyModel request, CancellationToken cancellationToken)
        {
            var lotInspectionQty = _mapper.Map<LotInspectionQty>(request);            

            await _repository.AddAsync(lotInspectionQty, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<LotInspectionQtyModel>(lotInspectionQty);
        }
    }
}
