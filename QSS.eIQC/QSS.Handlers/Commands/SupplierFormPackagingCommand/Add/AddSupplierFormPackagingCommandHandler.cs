/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormPackaging operation
    /// </summary>
    public class AddSupplierFormPackagingCommandHandler : IRequestHandler<AddSupplierFormPackagingModel, SupplierFormPackagingModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormPackagingRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormPackagingCommandHandler(QSSContext context, ISupplierFormPackagingRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormPackaging entity
        /// </summary>
        /// <param name="request">Add SupplierFormPackaging model, <see cref="AddSupplierFormPackagingModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormPackaging model</returns>
        public async Task<SupplierFormPackagingModel> Handle(AddSupplierFormPackagingModel request, CancellationToken cancellationToken)
        {
            var supplierFormPackaging = _mapper.Map<SupplierFormPackaging>(request);            

            await _repository.AddAsync(supplierFormPackaging, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormPackagingModel>(supplierFormPackaging);
        }
    }
}
