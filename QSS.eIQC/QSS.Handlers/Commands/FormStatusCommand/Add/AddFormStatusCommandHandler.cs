/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormStatus operation
    /// </summary>
    public class AddFormStatusCommandHandler : IRequestHandler<AddFormStatusModel, FormStatusModel>
    {
        private readonly QSSContext _context;
        private readonly IFormStatusRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormStatusCommandHandler(QSSContext context, IFormStatusRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormStatus entity
        /// </summary>
        /// <param name="request">Add FormStatus model, <see cref="AddFormStatusModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormStatus model</returns>
        public async Task<FormStatusModel> Handle(AddFormStatusModel request, CancellationToken cancellationToken)
        {
            var FormStatus = _mapper.Map<FormStatus>(request);            

            await _repository.AddAsync(FormStatus, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormStatusModel>(FormStatus);
        }
    }
}
