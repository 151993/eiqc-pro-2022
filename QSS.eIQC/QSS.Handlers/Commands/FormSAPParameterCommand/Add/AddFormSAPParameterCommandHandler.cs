/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormSAPParameter operation
    /// </summary>
    public class AddFormSAPParameterCommandHandler : IRequestHandler<AddFormSAPParameterModel, FormSAPParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormSAPParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormSAPParameterCommandHandler(QSSContext context, IFormSAPParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormSAPParameter entity
        /// </summary>
        /// <param name="request">Add FormSAPParameter model, <see cref="AddFormSAPParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormSAPParameter model</returns>
        public async Task<FormSAPParameterModel> Handle(AddFormSAPParameterModel request, CancellationToken cancellationToken)
        {
            var FormSAPParameter = _mapper.Map<FormSAPParameter>(request);            

            await _repository.AddAsync(FormSAPParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormSAPParameterModel>(FormSAPParameter);
        }
    }
}
