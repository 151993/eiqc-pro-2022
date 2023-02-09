/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierAttachment operation
    /// </summary>
    public class UpdateSupplierAttachmentCommandHandler : IRequestHandler<UpdateSupplierAttachmentModel, SupplierAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierAttachmentRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierAttachmentCommandHandler(QSSContext context, ISupplierAttachmentRepository supplierAttachmentRepository, IMapper mapper)
        {
            _context = context;
            _repository = supplierAttachmentRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SupplierAttachment entity
        /// </summary>
        /// <param name="request">Input Update SupplierAttachment model, <see cref="UpdateSupplierAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierAttachment model</returns>
        public async Task<SupplierAttachmentModel> Handle(UpdateSupplierAttachmentModel request, CancellationToken cancellationToken)
        {
            var supplierAttachment = _mapper.Map<SupplierAttachment>(request);          

            await _repository.UpdateAsync(supplierAttachment, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierAttachmentModel>(supplierAttachment);
        }
    }
}
