using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Add
{

    /// <summary>
	/// Command Handler for Add User operation
	/// </summary>
	public class AddPartInspectionCertificationAttachmentCommandHandler : IRequestHandler<AddPartInspectionCertificationAttachmentModel, PartInspectionCertificationAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionCertificationAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="repository">Injected instance of PartInspection Certification Attachment Repository on runtime, <see cref="IPartInspectionCertificationAttachmentRepository"/></param>
        public AddPartInspectionCertificationAttachmentCommandHandler(QSSContext context, IMapper mapper, IPartInspectionCertificationAttachmentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Add new User entity
        /// </summary>
        /// <param name="request">Add User model, <see cref="AddPartInspectionCertificationAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added User model</returns>
        public async Task<PartInspectionCertificationAttachmentModel> Handle(AddPartInspectionCertificationAttachmentModel request, CancellationToken cancellationToken)
        {
            var partInspectionCertificationAttachment = _mapper.Map<PartInspectionCertificationAttachment>(request);

            await _repository.AddAsync(partInspectionCertificationAttachment, partInspectionCertificationAttachment.Attachment.Name, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartInspectionCertificationAttachmentModel>(partInspectionCertificationAttachment);
        }
    }
}
