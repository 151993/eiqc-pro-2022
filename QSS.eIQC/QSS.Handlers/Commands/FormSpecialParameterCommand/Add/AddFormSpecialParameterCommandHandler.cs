/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormSpecialParameter operation
    /// </summary>
    public class AddFormSpecialParameterCommandHandler : IRequestHandler<AddFormSpecialParameterModel, FormSpecialParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormSpecialParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormSpecialParameterCommandHandler(QSSContext context, IFormSpecialParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormSpecialParameter entity
        /// </summary>
        /// <param name="request">Add FormSpecialParameter model, <see cref="AddFormSpecialParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormSpecialParameter model</returns>
        public async Task<FormSpecialParameterModel> Handle(AddFormSpecialParameterModel request, CancellationToken cancellationToken)
        {
            var FormSpecialParameter = _mapper.Map<FormSpecialParameter>(request);            

            await _repository.AddAsync(FormSpecialParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormSpecialParameterModel>(FormSpecialParameter);
        }
    }
}
