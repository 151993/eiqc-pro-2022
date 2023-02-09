/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormMeasurementParameter operation
    /// </summary>
    public class UpdateSupplierFormMeasurementParameterCommandHandler : IRequestHandler<UpdateSupplierFormMeasurementParameterModel, SupplierFormMeasurementParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMeasurementParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormMeasurementParameterCommandHandler(QSSContext context, ISupplierFormMeasurementParameterRepository supplierFormMeasurementParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormMeasurementParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormMeasurementParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormMeasurementParameter model, <see cref="UpdateSupplierFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormMeasurementParameter model</returns>
        public async Task<SupplierFormMeasurementParameterModel> Handle(UpdateSupplierFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormMeasurementParameter = _mapper.Map<SupplierFormMeasurementParameter>(request);          

            await _repository.UpdateAsync(supplierFormMeasurementParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMeasurementParameterModel>(supplierFormMeasurementParameter);
        }
    }
}
