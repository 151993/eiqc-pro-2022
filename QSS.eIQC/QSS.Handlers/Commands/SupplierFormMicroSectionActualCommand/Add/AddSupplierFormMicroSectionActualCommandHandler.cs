/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormMicroSectionActual operation
    /// </summary>
    public class AddSupplierFormMicroSectionActualCommandHandler : IRequestHandler<AddSupplierFormMicroSectionActualModel, SupplierFormMicroSectionActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMicroSectionActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormMicroSectionActualCommandHandler(QSSContext context, ISupplierFormMicroSectionActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormMicroSectionActual entity
        /// </summary>
        /// <param name="request">Add SupplierFormMicroSectionActual model, <see cref="AddSupplierFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormMicroSectionActual model</returns>
        public async Task<SupplierFormMicroSectionActualModel> Handle(AddSupplierFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormMicroSectionActual = _mapper.Map<SupplierFormMicroSectionActual>(request);            

            await _repository.AddAsync(supplierFormMicroSectionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMicroSectionActualModel>(supplierFormMicroSectionActual);
        }
    }
}
