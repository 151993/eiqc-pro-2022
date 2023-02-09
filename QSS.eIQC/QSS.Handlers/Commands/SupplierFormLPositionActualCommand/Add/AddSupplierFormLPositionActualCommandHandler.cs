/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormLPositionActual operation
    /// </summary>
    public class AddSupplierFormLPositionActualCommandHandler : IRequestHandler<AddSupplierFormLPositionActualModel, SupplierFormLPositionActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormLPositionActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormLPositionActualCommandHandler(QSSContext context, ISupplierFormLPositionActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormLPositionActual entity
        /// </summary>
        /// <param name="request">Add SupplierFormLPositionActual model, <see cref="AddSupplierFormLPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormLPositionActual model</returns>
        public async Task<SupplierFormLPositionActualModel> Handle(AddSupplierFormLPositionActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormLPositionActual = _mapper.Map<SupplierFormLPositionActual>(request);            

            await _repository.AddAsync(supplierFormLPositionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormLPositionActualModel>(supplierFormLPositionActual);
        }
    }
}
