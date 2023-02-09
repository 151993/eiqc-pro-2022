/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormBowTwistParameter operation
    /// </summary>
    public class UpdateSupplierFormBowTwistParameterCommandHandler : IRequestHandler<UpdateSupplierFormBowTwistParameterModel, SupplierFormBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormBowTwistParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormBowTwistParameterCommandHandler(QSSContext context, ISupplierFormBowTwistParameterRepository supplierFormBowTwistParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormBowTwistParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormBowTwistParameter entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormBowTwistParameter model, <see cref="UpdateSupplierFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormBowTwistParameter model</returns>
        public async Task<SupplierFormBowTwistParameterModel> Handle(UpdateSupplierFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormBowTwistParameter = _mapper.Map<SupplierFormBowTwistParameter>(request);          

            await _repository.UpdateAsync(supplierFormBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormBowTwistParameterModel>(supplierFormBowTwistParameter);
        }
    }
}
