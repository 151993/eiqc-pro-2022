/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormMicroSectionActual operation
    /// </summary>
    public class AddFormMicroSectionActualCommandHandler : IRequestHandler<AddFormMicroSectionActualModel, FormMicroSectionActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormMicroSectionActualCommandHandler(QSSContext context, IFormMicroSectionActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormMicroSectionActual entity
        /// </summary>
        /// <param name="request">Add FormMicroSectionActual model, <see cref="AddFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormMicroSectionActual model</returns>
        public async Task<FormMicroSectionActualModel> Handle(AddFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            var formMicroSectionActual = _mapper.Map<FormMicroSectionActual>(request);            

            await _repository.AddAsync(formMicroSectionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMicroSectionActualModel>(formMicroSectionActual);
        }
    }
}
