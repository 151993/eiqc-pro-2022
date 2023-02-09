/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormMicroSection operation
    /// </summary>
    public class AddFormMicroSectionCommandHandler : IRequestHandler<AddFormMicroSectionModel, FormMicroSectionModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormMicroSectionCommandHandler(QSSContext context, IFormMicroSectionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormMicroSection entity
        /// </summary>
        /// <param name="request">Add FormMicroSection model, <see cref="AddFormMicroSectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormMicroSection model</returns>
        public async Task<FormMicroSectionModel> Handle(AddFormMicroSectionModel request, CancellationToken cancellationToken)
        {
            var formMicroSection = _mapper.Map<FormMicroSection>(request);            

            await _repository.AddAsync(formMicroSection, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMicroSectionModel>(formMicroSection);
        }
    }
}
