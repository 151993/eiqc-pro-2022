/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormCountParameter operation
    /// </summary>
    public class UpdateSupplierFormCountParameterCommandHandler : IRequestHandler<UpdateSupplierFormCountParameterModel, SupplierFormCountParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormCountParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormCountParameterCommandHandler(QSSContext context, ISupplierFormCountParameterRepository supplierFormCountParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormCountParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormCountParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormCountParameter model, <see cref="UpdateSupplierFormCountParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormCountParameter model</returns>
        public async Task<SupplierFormCountParameterModel> Handle(UpdateSupplierFormCountParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormCountParameter = _mapper.Map<SupplierFormCountParameter>(request);          

            await _repository.UpdateAsync(supplierFormCountParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormCountParameterModel>(supplierFormCountParameter);
        }
    }
}
