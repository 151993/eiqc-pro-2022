using AutoMapper;
using FluentValidation;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Add
{
	/// <summary>
	/// Command Handler for Add User operation
	/// </summary>
	public class AddAdminCertificationAttachmentCommandHandler : 
        IRequestHandler<AddAdminCertificationAttachmentModel, AdminCertificationAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly IAdminCertificationAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="repository">Injected instance of Admin Certification Attachment Repository on runtime, <see cref="IAdminCertificationAttachmentRepository"/></param>
        public AddAdminCertificationAttachmentCommandHandler(QSSContext context, IMapper mapper, IAdminCertificationAttachmentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Add new User entity
        /// </summary>
        /// <param name="request">Add User model, <see cref="AddAdminCertificationAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added User model</returns>
        public async Task<AdminCertificationAttachmentModel> Handle(AddAdminCertificationAttachmentModel request, CancellationToken cancellationToken)
        {
            var adminCertificationAttachment = _mapper.Map<AdminCertificationAttachment>(request);

            await _repository.AddAsync(adminCertificationAttachment, adminCertificationAttachment.Attachment.Name, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<AdminCertificationAttachmentModel>(adminCertificationAttachment);
        }
    }
}
