/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormSpecialParameter operation
    /// </summary>
    public class UpdateSupplierFormSpecialParameterCommandHandler : IRequestHandler<UpdateSupplierFormSpecialParameterModel, SupplierFormSpecialParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSpecialParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormSpecialParameterCommandHandler(QSSContext context, ISupplierFormSpecialParameterRepository supplierFormSpecialParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormSpecialParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormSpecialParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormSpecialParameter model, <see cref="UpdateSupplierFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormSpecialParameter model</returns>
        public async Task<SupplierFormSpecialParameterModel> Handle(UpdateSupplierFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormSpecialParameter = _mapper.Map<SupplierFormSpecialParameter>(request);          

            await _repository.UpdateAsync(supplierFormSpecialParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormSpecialParameterModel>(supplierFormSpecialParameter);
        }
    }
}
