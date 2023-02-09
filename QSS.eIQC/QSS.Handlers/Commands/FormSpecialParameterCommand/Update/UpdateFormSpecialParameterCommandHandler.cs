/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormSpecialParameter operation
    /// </summary>
    public class UpdateFormSpecialParameterCommandHandler : IRequestHandler<UpdateFormSpecialParameterModel, FormSpecialParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormSpecialParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormSpecialParameterCommandHandler(QSSContext context, IFormSpecialParameterRepository FormSpecialParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = FormSpecialParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormSpecialParameter entity
        /// </summary>
        /// <param name="request">Input Update FormSpecialParameter model, <see cref="UpdateFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormSpecialParameter model</returns>
        public async Task<FormSpecialParameterModel> Handle(UpdateFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            var FormSpecialParameter = _mapper.Map<FormSpecialParameter>(request);          

            await _repository.UpdateAsync(FormSpecialParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormSpecialParameterModel>(FormSpecialParameter);
        }
    }
}
