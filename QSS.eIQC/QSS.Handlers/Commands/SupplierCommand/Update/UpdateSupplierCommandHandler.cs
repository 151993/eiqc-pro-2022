/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierCommand.Update
{
    /// <summary>
    /// Command Handler for Update Supplier operation
    /// </summary>
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierModel, SupplierModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierCommandHandler(QSSContext context, ISupplierRepository supplierRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Supplier entity
        /// </summary>
        /// <param name="request">Input Update Supplier model, <see cref="UpdateSupplierModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Supplier model</returns>
        public async Task<SupplierModel> Handle(UpdateSupplierModel request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Supplier>(request);          

            await _repository.UpdateAsync(supplier, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierModel>(supplier);
        }
    }
}
