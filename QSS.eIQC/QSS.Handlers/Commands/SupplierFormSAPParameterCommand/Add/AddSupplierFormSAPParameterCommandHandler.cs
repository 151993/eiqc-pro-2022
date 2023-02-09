/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormSAPParameter operation
    /// </summary>
    public class AddSupplierFormSAPParameterCommandHandler : IRequestHandler<AddSupplierFormSAPParameterModel, SupplierFormSAPParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormSAPParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormSAPParameterCommandHandler(QSSContext context, ISupplierFormSAPParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormSAPParameter entity
        /// </summary>
        /// <param name="request">Add SupplierFormSAPParameter model, <see cref="AddSupplierFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormSAPParameter model</returns>
        public async Task<SupplierFormSAPParameterModel> Handle(AddSupplierFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            var supplierFormSAPParameter = _mapper.Map<SupplierFormSAPParameter>(request);            

            await _repository.AddAsync(supplierFormSAPParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormSAPParameterModel>(supplierFormSAPParameter);
        }
    }
}
