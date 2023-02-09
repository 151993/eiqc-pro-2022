/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormMeasurementParameterActual operation
    /// </summary>
    public class UpdateSupplierFormMeasurementParameterActualCommandHandler : IRequestHandler<UpdateSupplierFormMeasurementParameterActualModel, SupplierFormMeasurementParameterActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMeasurementParameterActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormMeasurementParameterActualCommandHandler(QSSContext context, ISupplierFormMeasurementParameterActualRepository supplierFormMeasurementParameterActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormMeasurementParameterActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormMeasurementParameterActual entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormMeasurementParameterActual model, <see cref="UpdateSupplierFormMeasurementParameterActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormMeasurementParameterActual model</returns>
        public async Task<SupplierFormMeasurementParameterActualModel> Handle(UpdateSupplierFormMeasurementParameterActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormMeasurementParameterActual = _mapper.Map<SupplierFormMeasurementParameterActual>(request);          

            await _repository.UpdateAsync(supplierFormMeasurementParameterActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMeasurementParameterActualModel>(supplierFormMeasurementParameterActual);
        }
    }
}
