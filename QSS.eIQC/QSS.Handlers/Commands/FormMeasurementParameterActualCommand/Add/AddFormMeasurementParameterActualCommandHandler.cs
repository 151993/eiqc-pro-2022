/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormMeasurementParameterActual operation
    /// </summary>
    public class AddFormMeasurementParameterActualCommandHandler : IRequestHandler<AddFormMeasurementParameterActualModel, FormMeasurementParameterActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormMeasurementParameterActualCommandHandler(QSSContext context, IFormMeasurementParameterActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormMeasurementParameterActual entity
        /// </summary>
        /// <param name="request">Add FormMeasurementParameterActual model, <see cref="AddFormMeasurementParameterActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormMeasurementParameterActual model</returns>
        public async Task<FormMeasurementParameterActualModel> Handle(AddFormMeasurementParameterActualModel request, CancellationToken cancellationToken)
        {
            var formMeasurementParameterActual = _mapper.Map<FormMeasurementParameterActual>(request);            

            await _repository.AddAsync(formMeasurementParameterActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMeasurementParameterActualModel>(formMeasurementParameterActual);
        }
    }
}
