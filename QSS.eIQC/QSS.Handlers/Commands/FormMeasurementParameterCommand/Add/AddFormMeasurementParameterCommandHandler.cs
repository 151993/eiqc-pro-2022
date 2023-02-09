/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormMeasurementParameter operation
    /// </summary>
    public class AddFormMeasurementParameterCommandHandler : IRequestHandler<AddFormMeasurementParameterModel, FormMeasurementParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormMeasurementParameterCommandHandler(QSSContext context, IFormMeasurementParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormMeasurementParameter entity
        /// </summary>
        /// <param name="request">Add FormMeasurementParameter model, <see cref="AddFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormMeasurementParameter model</returns>
        public async Task<FormMeasurementParameterModel> Handle(AddFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            var formMeasurementParameter = _mapper.Map<FormMeasurementParameter>(request);            

            await _repository.AddAsync(formMeasurementParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMeasurementParameterModel>(formMeasurementParameter);
        }
    }
}
