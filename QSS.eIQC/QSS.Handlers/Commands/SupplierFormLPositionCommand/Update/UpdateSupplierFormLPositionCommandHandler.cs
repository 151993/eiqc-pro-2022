/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormLPosition operation
    /// </summary>
    public class UpdateSupplierFormLPositionCommandHandler : IRequestHandler<UpdateSupplierFormLPositionModel, SupplierFormLPositionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormLPositionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormLPositionCommandHandler(QSSContext context, ISupplierFormLPositionRepository supplierFormLPositionRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormLPositionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormLPosition entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormLPosition model, <see cref="UpdateSupplierFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormLPosition model</returns>
        public async Task<SupplierFormLPositionModel> Handle(UpdateSupplierFormLPositionModel request, CancellationToken cancellationToken)
        {
            var supplierFormLPosition = _mapper.Map<SupplierFormLPosition>(request);          

            await _repository.UpdateAsync(supplierFormLPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormLPositionModel>(supplierFormLPosition);
        }
    }
}
