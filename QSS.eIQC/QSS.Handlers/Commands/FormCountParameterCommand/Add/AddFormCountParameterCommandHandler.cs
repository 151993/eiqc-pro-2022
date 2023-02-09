/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormCountParameter operation
    /// </summary>
    public class AddFormCountParameterCommandHandler : IRequestHandler<AddFormCountParameterModel, FormCountParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormCountParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormCountParameterCommandHandler(QSSContext context, IFormCountParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormCountParameter entity
        /// </summary>
        /// <param name="request">Add FormCountParameter model, <see cref="AddFormCountParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormCountParameter model</returns>
        public async Task<FormCountParameterModel> Handle(AddFormCountParameterModel request, CancellationToken cancellationToken)
        {
            var formCountParameter = _mapper.Map<FormCountParameter>(request);            

            await _repository.AddAsync(formCountParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormCountParameterModel>(formCountParameter);
        }
    }
}
