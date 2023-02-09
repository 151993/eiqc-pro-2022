/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormLPosition operation
    /// </summary>
    public class AddSupplierFormLPositionCommandHandler : IRequestHandler<AddSupplierFormLPositionModel, SupplierFormLPositionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormLPositionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormLPositionCommandHandler(QSSContext context, ISupplierFormLPositionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormLPosition entity
        /// </summary>
        /// <param name="request">Add SupplierFormLPosition model, <see cref="AddSupplierFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormLPosition model</returns>
        public async Task<SupplierFormLPositionModel> Handle(AddSupplierFormLPositionModel request, CancellationToken cancellationToken)
        {
            var supplierFormLPosition = _mapper.Map<SupplierFormLPosition>(request);            

            await _repository.AddAsync(supplierFormLPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormLPositionModel>(supplierFormLPosition);
        }
    }
}
