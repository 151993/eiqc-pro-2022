using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.EmailTemplateCommand.Update
{
    /// <summary>
    /// Command Handler for Update EmailTemplate operation
    /// </summary>
    public class UpdateEmailTemplateCommandHandler : IRequestHandler<UpdateEmailTemplateModel, EmailTemplateModel>
    {
        private readonly QSSContext _context;
        private readonly IEmailTemplateRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="repository">Injected instance of IEmailTemplateRepository on runtime, <see cref="IEmailTemplateRepository"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateEmailTemplateCommandHandler(QSSContext context, IEmailTemplateRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update EmailTemplate entity
        /// </summary>
        /// <param name="request">Input Update EmailTemplate model, <see cref="UpdateEmailTemplateModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated EmailTemplate model</returns>
        public async Task<EmailTemplateModel> Handle(UpdateEmailTemplateModel request, CancellationToken cancellationToken)
        {
            var emailTemplate = _mapper.Map<EmailTemplate>(request);

            await _repository.UpdateAsync(emailTemplate, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<EmailTemplateModel>(emailTemplate);
        }
    }
}
