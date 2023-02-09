/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormBowTwistActual operation
    /// </summary>
    public class UpdateSupplierFormBowTwistActualCommandHandler : IRequestHandler<UpdateSupplierFormBowTwistActualModel, SupplierFormBowTwistActualModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormBowTwistActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormBowTwistActualCommandHandler(QSSContext context, ISupplierFormBowTwistActualRepository supplierFormBowTwistActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormBowTwistActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormBowTwistActual entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormBowTwistActual model, <see cref="UpdateSupplierFormBowTwistActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormBowTwistActual model</returns>
        public async Task<SupplierFormBowTwistActualModel> Handle(UpdateSupplierFormBowTwistActualModel request, CancellationToken cancellationToken)
        {
            var supplierFormBowTwistActual = _mapper.Map<SupplierFormBowTwistActual>(request);          

            await _repository.UpdateAsync(supplierFormBowTwistActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormBowTwistActualModel>(supplierFormBowTwistActual);
        }
    }
}
