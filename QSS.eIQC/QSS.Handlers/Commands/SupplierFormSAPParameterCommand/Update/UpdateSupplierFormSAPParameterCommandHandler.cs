/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormSAPParameter operation
    /// </summary>
    public class UpdateSupplierFormSAPParameterCommandHandler : IRequestHandler<UpdateSupplierFormSAPParameterModel, SupplierFormSAPParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSAPParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormSAPParameterCommandHandler(QSSContext context, ISupplierFormSAPParameterRepository supplierFormSAPParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormSAPParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormSAPParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormSAPParameter model, <see cref="UpdateSupplierFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormSAPParameter model</returns>
        public async Task<SupplierFormSAPParameterModel> Handle(UpdateSupplierFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormSAPParameter = _mapper.Map<SupplierFormSAPParameter>(request);          

            await _repository.UpdateAsync(supplierFormSAPParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormSAPParameterModel>(supplierFormSAPParameter);
        }
    }
}
