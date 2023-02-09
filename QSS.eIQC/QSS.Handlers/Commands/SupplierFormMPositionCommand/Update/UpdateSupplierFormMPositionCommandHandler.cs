/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormMPosition operation
    /// </summary>
    public class UpdateSupplierFormMPositionCommandHandler : IRequestHandler<UpdateSupplierFormMPositionModel, SupplierFormMPositionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMPositionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormMPositionCommandHandler(QSSContext context, ISupplierFormMPositionRepository supplierFormMPositionRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormMPositionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormMPosition entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormMPosition model, <see cref="UpdateSupplierFormMPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormMPosition model</returns>
        public async Task<SupplierFormMPositionModel> Handle(UpdateSupplierFormMPositionModel request, CancellationToken cancellationToken)
        {
            var supplierFormMPosition = _mapper.Map<SupplierFormMPosition>(request);          

            await _repository.UpdateAsync(supplierFormMPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMPositionModel>(supplierFormMPosition);
        }
    }
}
