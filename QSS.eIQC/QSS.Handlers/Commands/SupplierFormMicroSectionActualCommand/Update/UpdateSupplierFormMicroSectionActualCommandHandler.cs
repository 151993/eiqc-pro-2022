/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormMicroSectionActual operation
    /// </summary>
    public class UpdateSupplierFormMicroSectionActualCommandHandler : IRequestHandler<UpdateSupplierFormMicroSectionActualModel, SupplierFormMicroSectionActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMicroSectionActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormMicroSectionActualCommandHandler(QSSContext context, ISupplierFormMicroSectionActualRepository supplierFormMicroSectionActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormMicroSectionActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormMicroSectionActual entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormMicroSectionActual model, <see cref="UpdateSupplierFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormMicroSectionActual model</returns>
        public async Task<SupplierFormMicroSectionActualModel> Handle(UpdateSupplierFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormMicroSectionActual = _mapper.Map<SupplierFormMicroSectionActual>(request);          

            await _repository.UpdateAsync(supplierFormMicroSectionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMicroSectionActualModel>(supplierFormMicroSectionActual);
        }
    }
}
