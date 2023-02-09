/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormSpecialParameter operation
    /// </summary>
    public class AddSupplierFormSpecialParameterCommandHandler : IRequestHandler<AddSupplierFormSpecialParameterModel, SupplierFormSpecialParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSpecialParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormSpecialParameterCommandHandler(QSSContext context, ISupplierFormSpecialParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormSpecialParameter entity
        /// </summary>
        /// <param name="request">Add SupplierFormSpecialParameter model, <see cref="AddSupplierFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormSpecialParameter model</returns>
        public async Task<SupplierFormSpecialParameterModel> Handle(AddSupplierFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormSpecialParameter = _mapper.Map<SupplierFormSpecialParameter>(request);            

            await _repository.AddAsync(supplierFormSpecialParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormSpecialParameterModel>(supplierFormSpecialParameter);
        }
    }
}
