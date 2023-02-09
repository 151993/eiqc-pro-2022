/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormFunParaActual operation
    /// </summary>
    public class UpdateSupplierFormFunParaActualCommandHandler : IRequestHandler<UpdateSupplierFormFunParaActualModel, SupplierFormFunParaActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormFunParaActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormFunParaActualCommandHandler(QSSContext context, ISupplierFormFunParaActualRepository supplierFormFunParaActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormFunParaActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormFunParaActual entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormFunParaActual model, <see cref="UpdateSupplierFormFunParaActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormFunParaActual model</returns>
        public async Task<SupplierFormFunParaActualModel> Handle(UpdateSupplierFormFunParaActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormFunParaActual = _mapper.Map<SupplierFormFunParaActual>(request);          

            await _repository.UpdateAsync(supplierFormFunParaActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormFunParaActualModel>(supplierFormFunParaActual);
        }
    }
}
