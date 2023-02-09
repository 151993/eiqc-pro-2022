/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormBowTwistParameter operation
    /// </summary>
    public class AddSupplierFormBowTwistParameterCommandHandler : IRequestHandler<AddSupplierFormBowTwistParameterModel, SupplierFormBowTwistParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormBowTwistParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormBowTwistParameterCommandHandler(QSSContext context, ISupplierFormBowTwistParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormBowTwistParameter entity
        /// </summary>
        /// <param name="request">Add SupplierFormBowTwistParameter model, <see cref="AddSupplierFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormBowTwistParameter model</returns>
        public async Task<SupplierFormBowTwistParameterModel> Handle(AddSupplierFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormBowTwistParameter = _mapper.Map<SupplierFormBowTwistParameter>(request);            

            await _repository.AddAsync(supplierFormBowTwistParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormBowTwistParameterModel>(supplierFormBowTwistParameter);
        }
    }
}
