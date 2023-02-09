/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormMeasurementParameterActual operation
    /// </summary>
    public class UpdateFormMeasurementParameterActualCommandHandler : IRequestHandler<UpdateFormMeasurementParameterActualModel, FormMeasurementParameterActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormMeasurementParameterActualCommandHandler(QSSContext context, IFormMeasurementParameterActualRepository formMeasurementParameterActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = formMeasurementParameterActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormMeasurementParameterActual entity
        /// </summary>
        /// <param name="request">Input Update FormMeasurementParameterActual model, <see cref="UpdateFormMeasurementParameterActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormMeasurementParameterActual model</returns>
        public async Task<FormMeasurementParameterActualModel> Handle(UpdateFormMeasurementParameterActualModel request, CancellationToken cancellationToken)
        {
            var formMeasurementParameterActual = _mapper.Map<FormMeasurementParameterActual>(request);          

            await _repository.UpdateAsync(formMeasurementParameterActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMeasurementParameterActualModel>(formMeasurementParameterActual);
        }
    }
}
