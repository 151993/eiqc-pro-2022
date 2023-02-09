/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormMicroSection operation
    /// </summary>
    public class AddSupplierFormMicroSectionCommandHandler : IRequestHandler<AddSupplierFormMicroSectionModel, SupplierFormMicroSectionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMicroSectionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormMicroSectionCommandHandler(QSSContext context, ISupplierFormMicroSectionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormMicroSection entity
        /// </summary>
        /// <param name="request">Add SupplierFormMicroSection model, <see cref="AddSupplierFormMicroSectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormMicroSection model</returns>
        public async Task<SupplierFormMicroSectionModel> Handle(AddSupplierFormMicroSectionModel request, CancellationToken cancellationToken)
        {
            var supplierFormMicroSection = _mapper.Map<SupplierFormMicroSection>(request);            

            await _repository.AddAsync(supplierFormMicroSection, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMicroSectionModel>(supplierFormMicroSection);
        }
    }
}
