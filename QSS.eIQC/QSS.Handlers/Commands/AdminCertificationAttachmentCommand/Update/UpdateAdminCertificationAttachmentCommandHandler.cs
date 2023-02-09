using AutoMapper;
using FluentValidation;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Update
{
    /// <summary>
    /// Update CommodityAttachment logic
    /// </summary>
    public class UpdateAdminCertificationAttachmentCommandHandler : 
        IRequestHandler<UpdateAdminCertificationAttachmentModel, AdminCertificationAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly IAdminCertificationAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateAdminCertificationAttachmentCommandHandler(QSSContext context, IMapper mapper, IAdminCertificationAttachmentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Update AdminCertificationAttachment entity
        /// </summary>
        /// <param name="request">Input Update AdminCertificationAttachment model, <see cref="UpdateAdminCertificationAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated AdminCertificationAttachment model</returns>
        public async Task<AdminCertificationAttachmentModel> Handle(UpdateAdminCertificationAttachmentModel request, CancellationToken cancellationToken)
        {
            var adminCertificationAttachment = _mapper.Map<AdminCertificationAttachment>(request);

			await _repository.UpdateAsync(adminCertificationAttachment, adminCertificationAttachment.Attachment.Name, request.ChangeReason);

            _context.SaveChanges();
            
            return _mapper.Map<AdminCertificationAttachmentModel>(adminCertificationAttachment);
        }
    }
}
