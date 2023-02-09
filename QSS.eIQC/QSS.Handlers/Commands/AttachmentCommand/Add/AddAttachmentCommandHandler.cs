using AutoMapper;
using FluentValidation;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand.Add
{
	/// <summary>
	/// Command Handler for Add User operation
	/// </summary>
	public class AddAttachmentCommandHandler : IRequestHandler<AddAttachmentModel, AttachmentModel>
    {
        private readonly QSSContext _context;
        private readonly IAttachmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddAttachmentCommandHandler(QSSContext context, IMapper mapper, IAttachmentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Add new Attachment entity
        /// </summary>
        /// <param name="request">Add Attachment model, <see cref="AddAttachmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Attachment model</returns>
        public async Task<AttachmentModel> Handle(AddAttachmentModel request, CancellationToken cancellationToken)
        {
	        var attachment = _mapper.Map<Attachment>(request);

            await _repository.AddAsync(attachment, request.ChangeReason);

	        _context.SaveChanges();

	        return _mapper.Map<AttachmentModel>(attachment);
        }
    }
}
