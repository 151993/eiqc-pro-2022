/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormPartDateCode operation
    /// </summary>
    public class AddSupplierFormPartDateCodeCommandHandler : IRequestHandler<AddSupplierFormPartDateCodeModel, SupplierFormPartDateCodeModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormPartDateCodeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormPartDateCodeCommandHandler(QSSContext context, ISupplierFormPartDateCodeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormPartDateCode entity
        /// </summary>
        /// <param name="request">Add SupplierFormPartDateCode model, <see cref="AddSupplierFormPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormPartDateCode model</returns>
        public async Task<SupplierFormPartDateCodeModel> Handle(AddSupplierFormPartDateCodeModel request, CancellationToken cancellationToken)
        {
            var supplierFormPartDateCode = _mapper.Map<SupplierFormPartDateCode>(request);            

            await _repository.AddAsync(supplierFormPartDateCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormPartDateCodeModel>(supplierFormPartDateCode);
        }
    }
}
