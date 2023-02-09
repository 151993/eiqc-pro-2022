/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormVIS operation
    /// </summary>
    public class AddSupplierFormVISCommandHandler : IRequestHandler<AddSupplierFormVISModel, SupplierFormVISModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormVISRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormVISCommandHandler(QSSContext context, ISupplierFormVISRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormVIS entity
        /// </summary>
        /// <param name="request">Add SupplierFormVIS model, <see cref="AddSupplierFormVISModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormVIS model</returns>
        public async Task<SupplierFormVISModel> Handle(AddSupplierFormVISModel request, CancellationToken cancellationToken)
        {
            var supplierFormVIS = _mapper.Map<SupplierFormVIS>(request);            

            await _repository.AddAsync(supplierFormVIS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormVISModel>(supplierFormVIS);
        }
    }
}
