/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Add
{
    /// <summary>
    /// Command Handler for Add Form operation
    /// </summary>
    public class AddFormCommandHandler : IRequestHandler<AddFormModel, FormModel>
    {
        private readonly QSSContext _context;
        private readonly IFormRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormCommandHandler(QSSContext context, IFormRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Form entity
        /// </summary>
        /// <param name="request">Add Form model, <see cref="AddFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Form model</returns>
        public async Task<FormModel> Handle(AddFormModel request, CancellationToken cancellationToken)
        {
            var form = _mapper.Map<Form>(request);            

            await _repository.AddAsync(form, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormModel>(form);
        }
    }
}
