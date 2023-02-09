/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CTParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add CTParameter operation
    /// </summary>
    public class AddCTParameterCommandHandler : IRequestHandler<AddCTParameterModel, CTParameterModel>
    {
        private readonly QSSContext _context;
        private readonly ICTParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCTParameterCommandHandler(QSSContext context, ICTParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new CTParameter entity
        /// </summary>
        /// <param name="request">Add CTParameter model, <see cref="AddCTParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added CTParameter model</returns>
        public async Task<CTParameterModel> Handle(AddCTParameterModel request, CancellationToken cancellationToken)
        {
            var cTParameter = _mapper.Map<CTParameter>(request);            

            await _repository.AddAsync(cTParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CTParameterModel>(cTParameter);
        }
    }
}
