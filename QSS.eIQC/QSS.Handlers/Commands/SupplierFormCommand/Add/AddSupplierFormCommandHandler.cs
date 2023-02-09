/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierForm operation
    /// </summary>
    public class AddSupplierFormCommandHandler : IRequestHandler<AddSupplierFormModel, SupplierFormModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormCommandHandler(QSSContext context, ISupplierFormRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierForm entity
        /// </summary>
        /// <param name="request">Add SupplierForm model, <see cref="AddSupplierFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierForm model</returns>
        public async Task<SupplierFormModel> Handle(AddSupplierFormModel request, CancellationToken cancellationToken)
        {
            var supplierForm = _mapper.Map<SupplierForm>(request);            

            await _repository.AddAsync(supplierForm, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormModel>(supplierForm);
        }
    }
}
