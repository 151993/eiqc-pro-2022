/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormMeasurementParameter operation
    /// </summary>
    public class AddSupplierFormMeasurementParameterCommandHandler : IRequestHandler<AddSupplierFormMeasurementParameterModel, SupplierFormMeasurementParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMeasurementParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormMeasurementParameterCommandHandler(QSSContext context, ISupplierFormMeasurementParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormMeasurementParameter entity
        /// </summary>
        /// <param name="request">Add SupplierFormMeasurementParameter model, <see cref="AddSupplierFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormMeasurementParameter model</returns>
        public async Task<SupplierFormMeasurementParameterModel> Handle(AddSupplierFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormMeasurementParameter = _mapper.Map<SupplierFormMeasurementParameter>(request);            

            await _repository.AddAsync(supplierFormMeasurementParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMeasurementParameterModel>(supplierFormMeasurementParameter);
        }
    }
}
