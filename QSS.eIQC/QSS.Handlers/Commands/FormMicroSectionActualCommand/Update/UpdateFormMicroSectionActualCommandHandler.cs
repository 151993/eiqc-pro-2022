/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormMicroSectionActual operation
    /// </summary>
    public class UpdateFormMicroSectionActualCommandHandler : IRequestHandler<UpdateFormMicroSectionActualModel, FormMicroSectionActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMicroSectionActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormMicroSectionActualCommandHandler(QSSContext context, IFormMicroSectionActualRepository formMicroSectionActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = formMicroSectionActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormMicroSectionActual entity
        /// </summary>
        /// <param name="request">Input Update FormMicroSectionActual model, <see cref="UpdateFormMicroSectionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormMicroSectionActual model</returns>
        public async Task<FormMicroSectionActualModel> Handle(UpdateFormMicroSectionActualModel request, CancellationToken cancellationToken)
        {
            var formMicroSectionActual = _mapper.Map<FormMicroSectionActual>(request);          

            await _repository.UpdateAsync(formMicroSectionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMicroSectionActualModel>(formMicroSectionActual);
        }
    }
}
