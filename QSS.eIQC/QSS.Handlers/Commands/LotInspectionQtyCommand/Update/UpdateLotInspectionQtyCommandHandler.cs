/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Update
{
    /// <summary>
    /// Command Handler for Update LotInspectionQty operation
    /// </summary>
    public class UpdateLotInspectionQtyCommandHandler : IRequestHandler<UpdateLotInspectionQtyModel, LotInspectionQtyModel>
    {
        private readonly QSSContext _context;
        private readonly ILotInspectionQtyRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateLotInspectionQtyCommandHandler(QSSContext context, ILotInspectionQtyRepository lotInspectionQtyRepository, IMapper mapper)
        {
            _context = context;
            _repository = lotInspectionQtyRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update LotInspectionQty entity
        /// </summary>
        /// <param name="request">Input Update LotInspectionQty model, <see cref="UpdateLotInspectionQtyModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated LotInspectionQty model</returns>
        public async Task<LotInspectionQtyModel> Handle(UpdateLotInspectionQtyModel request, CancellationToken cancellationToken)
        {
            var lotInspectionQty = _mapper.Map<LotInspectionQty>(request);          

            await _repository.UpdateAsync(lotInspectionQty, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<LotInspectionQtyModel>(lotInspectionQty);
        }
    }
}
