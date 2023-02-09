/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormMPositionActual operation
    /// </summary>
    public class UpdateSupplierFormMPositionActualCommandHandler : IRequestHandler<UpdateSupplierFormMPositionActualModel, SupplierFormMPositionActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMPositionActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormMPositionActualCommandHandler(QSSContext context, ISupplierFormMPositionActualRepository supplierFormMPositionActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormMPositionActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormMPositionActual entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormMPositionActual model, <see cref="UpdateSupplierFormMPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormMPositionActual model</returns>
        public async Task<SupplierFormMPositionActualModel> Handle(UpdateSupplierFormMPositionActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormMPositionActual = _mapper.Map<SupplierFormMPositionActual>(request);          

            await _repository.UpdateAsync(supplierFormMPositionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMPositionActualModel>(supplierFormMPositionActual);
        }
    }
}
