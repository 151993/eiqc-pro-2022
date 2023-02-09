/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierFormFunPara operation
    /// </summary>
    public class AddSupplierFormFunParaCommandHandler : IRequestHandler<AddSupplierFormFunParaModel, SupplierFormFunParaModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormFunParaRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierFormFunParaCommandHandler(QSSContext context, ISupplierFormFunParaRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierFormFunPara entity
        /// </summary>
        /// <param name="request">Add SupplierFormFunPara model, <see cref="AddSupplierFormFunParaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierFormFunPara model</returns>
        public async Task<SupplierFormFunParaModel> Handle(AddSupplierFormFunParaModel request, CancellationToken cancellationToken)
        {
            var supplierFormFunPara = _mapper.Map<SupplierFormFunPara>(request);            

            await _repository.AddAsync(supplierFormFunPara, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormFunParaModel>(supplierFormFunPara);
        }
    }
}
