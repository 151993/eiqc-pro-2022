/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormMeasurementParameter operation
    /// </summary>
    public class UpdateFormMeasurementParameterCommandHandler : IRequestHandler<UpdateFormMeasurementParameterModel, FormMeasurementParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMeasurementParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormMeasurementParameterCommandHandler(QSSContext context, IFormMeasurementParameterRepository formMeasurementParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = formMeasurementParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormMeasurementParameter entity
        /// </summary>
        /// <param name="request">Input Update FormMeasurementParameter model, <see cref="UpdateFormMeasurementParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormMeasurementParameter model</returns>
        public async Task<FormMeasurementParameterModel> Handle(UpdateFormMeasurementParameterModel request, CancellationToken cancellationToken)
        {
            var formMeasurementParameter = _mapper.Map<FormMeasurementParameter>(request);          

            await _repository.UpdateAsync(formMeasurementParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMeasurementParameterModel>(formMeasurementParameter);
        }
    }
}
