/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormMPosition operation
    /// </summary>
    public class AddSupplierFormMPositionCommandHandler : IRequestHandler<AddSupplierFormMPositionModel, SupplierFormMPositionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormMPositionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormMPositionCommandHandler(QSSContext context, ISupplierFormMPositionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormMPosition entity
        /// </summary>
        /// <param name="request">Add SupplierFormMPosition model, <see cref="AddSupplierFormMPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormMPosition model</returns>
        public async Task<SupplierFormMPositionModel> Handle(AddSupplierFormMPositionModel request, CancellationToken cancellationToken)
        {
            var supplierFormMPosition = _mapper.Map<SupplierFormMPosition>(request);            

            await _repository.AddAsync(supplierFormMPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormMPositionModel>(supplierFormMPosition);
        }
    }
}
