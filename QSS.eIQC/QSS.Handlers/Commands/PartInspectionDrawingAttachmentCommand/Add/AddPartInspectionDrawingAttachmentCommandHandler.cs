using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add
{
    /// <summary>
	/// Command Handler for Add User operation
	/// </summary>
	public class AddPartInspectionDrawingAttachmentCommandHandler : IRequestHandler<AddPartInspectionDrawingAttachmentModel, PartInspectionDrawingAttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionDrawingAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="repository">Injected instance of PartInspectionDrawingAttachment Repository on runtime, <see cref="IAdminCertificationAttachmentRepository"/></param>
        public AddPartInspectionDrawingAttachmentCommandHandler(QSSContext context, IMapper mapper, IPartInspectionDrawingAttachmentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Add new User entity
        /// </summary>
        /// <param name="request">Add User model, <see cref="AddPartInspectionDrawingAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added User model</returns>
        public async Task<PartInspectionDrawingAttachmentModel> Handle(AddPartInspectionDrawingAttachmentModel request, CancellationToken cancellationToken)
        {
            var partInspectionDrawingAttachment = _mapper.Map<PartInspectionDrawingAttachment>(request);

            await _repository.AddAsync(partInspectionDrawingAttachment, partInspectionDrawingAttachment.Attachment.Name, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartInspectionDrawingAttachmentModel>(partInspectionDrawingAttachment);
        }
    }
}
