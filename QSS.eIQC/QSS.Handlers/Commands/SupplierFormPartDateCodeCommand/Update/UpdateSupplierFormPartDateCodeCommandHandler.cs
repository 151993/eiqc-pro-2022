/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierFormPartDateCode operation
    /// </summary>
    public class UpdateSupplierFormPartDateCodeCommandHandler : IRequestHandler<UpdateSupplierFormPartDateCodeModel, SupplierFormPartDateCodeModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierFormPartDateCodeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierFormPartDateCodeCommandHandler(QSSContext context, ISupplierFormPartDateCodeRepository supplierFormPartDateCodeRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierFormPartDateCodeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierFormPartDateCode entity
        /// </summary>
        /// <param name="request">Input Update SupplierFormPartDateCode model, <see cref="UpdateSupplierFormPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierFormPartDateCode model</returns>
        public async Task<SupplierFormPartDateCodeModel> Handle(UpdateSupplierFormPartDateCodeModel request, CancellationToken cancellationToken)
        {
            var supplierFormPartDateCode = _mapper.Map<SupplierFormPartDateCode>(request);          

            await _repository.UpdateAsync(supplierFormPartDateCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierFormPartDateCodeModel>(supplierFormPartDateCode);
        }
    }
}
