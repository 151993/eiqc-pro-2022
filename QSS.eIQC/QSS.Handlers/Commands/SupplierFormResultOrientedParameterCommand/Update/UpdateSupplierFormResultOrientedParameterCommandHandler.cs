/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormResultOrientedParameter operation
    /// </summary>
    public class UpdateSupplierFormResultOrientedParameterCommandHandler : IRequestHandler<UpdateSupplierFormResultOrientedParameterModel, SupplierFormResultOrientedParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormResultOrientedParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormResultOrientedParameterCommandHandler(QSSContext context, ISupplierFormResultOrientedParameterRepository supplierFormResultOrientedParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormResultOrientedParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormResultOrientedParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormResultOrientedParameter model, <see cref="UpdateSupplierFormResultOrientedParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormResultOrientedParameter model</returns>
        public async Task<SupplierFormResultOrientedParameterModel> Handle(UpdateSupplierFormResultOrientedParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormResultOrientedParameter = _mapper.Map<SupplierFormResultOrientedParameter>(request);          

            await _repository.UpdateAsync(supplierFormResultOrientedParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormResultOrientedParameterModel>(supplierFormResultOrientedParameter);
        }
    }
}
