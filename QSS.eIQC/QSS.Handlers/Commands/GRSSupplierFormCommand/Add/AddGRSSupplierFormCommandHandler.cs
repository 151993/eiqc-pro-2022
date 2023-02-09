/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Add
{
    /// <summary>
    /// Command Handler for Add GRSSupplierForm operation
    /// </summary>
    public class AddGRSSupplierFormCommandHandler : IRequestHandler<AddGRSSupplierFormModel, GRSSupplierFormModel>
    {
        private readonly QSSContext _context;
        private readonly IGRSSupplierFormRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddGRSSupplierFormCommandHandler(QSSContext context, IGRSSupplierFormRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new GRSSupplierForm entity
        /// </summary>
        /// <param name="request">Add GRSSupplierForm model, <see cref="AddGRSSupplierFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added GRSSupplierForm model</returns>
        public async Task<GRSSupplierFormModel> Handle(AddGRSSupplierFormModel request, CancellationToken cancellationToken)
        {
            var gRSSupplierForm = _mapper.Map<GRSSupplierForm>(request);            

            await _repository.AddAsync(gRSSupplierForm, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GRSSupplierFormModel>(gRSSupplierForm);
        }
    }
}
