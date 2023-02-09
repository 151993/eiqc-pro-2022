/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormMicroSection operation
    /// </summary>
    public class UpdateFormMicroSectionCommandHandler : IRequestHandler<UpdateFormMicroSectionModel, FormMicroSectionModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormMicroSectionCommandHandler(QSSContext context, IFormMicroSectionRepository formMicroSectionRepository, IMapper mapper)
        {
            _context = context;
            _repository = formMicroSectionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormMicroSection entity
        /// </summary>
        /// <param name="request">Input Update FormMicroSection model, <see cref="UpdateFormMicroSectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormMicroSection model</returns>
        public async Task<FormMicroSectionModel> Handle(UpdateFormMicroSectionModel request, CancellationToken cancellationToken)
        {
            var formMicroSection = _mapper.Map<FormMicroSection>(request);          

            await _repository.UpdateAsync(formMicroSection, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMicroSectionModel>(formMicroSection);
        }
    }
}
