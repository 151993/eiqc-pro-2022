/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormSAPParameter operation
    /// </summary>
    public class UpdateFormSAPParameterCommandHandler : IRequestHandler<UpdateFormSAPParameterModel, FormSAPParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormSAPParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormSAPParameterCommandHandler(QSSContext context, IFormSAPParameterRepository FormSAPParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = FormSAPParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormSAPParameter entity
        /// </summary>
        /// <param name="request">Input Update FormSAPParameter model, <see cref="UpdateFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormSAPParameter model</returns>
        public async Task<FormSAPParameterModel> Handle(UpdateFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            var FormSAPParameter = _mapper.Map<FormSAPParameter>(request);          

            await _repository.UpdateAsync(FormSAPParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormSAPParameterModel>(FormSAPParameter);
        }
    }
}
