/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierAttachment operation
    /// </summary>
    public class AddSupplierAttachmentCommandHandler : IRequestHandler<AddSupplierAttachmentModel, SupplierAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierAttachmentCommandHandler(QSSContext context, ISupplierAttachmentRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SupplierAttachment entity
        /// </summary>
        /// <param name="request">Add SupplierAttachment model, <see cref="AddSupplierAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierAttachment model</returns>
        public async Task<SupplierAttachmentModel> Handle(AddSupplierAttachmentModel request, CancellationToken cancellationToken)
        {
            var supplierAttachment = _mapper.Map<SupplierAttachment>(request);            

            await _repository.AddAsync(supplierAttachment, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SupplierAttachmentModel>(supplierAttachment);
        }
    }
}
