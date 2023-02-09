/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMPositionActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormMPositionActual operation
    /// </summary>
    public class AddFormMPositionActualCommandHandler : IRequestHandler<AddFormMPositionActualModel, FormMPositionActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMPositionActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormMPositionActualCommandHandler(QSSContext context, IFormMPositionActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormMPositionActual entity
        /// </summary>
        /// <param name="request">Add FormMPositionActual model, <see cref="AddFormMPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormMPositionActual model</returns>
        public async Task<FormMPositionActualModel> Handle(AddFormMPositionActualModel request, CancellationToken cancellationToken)
        {
            var formMPositionActual = _mapper.Map<FormMPositionActual>(request);            

            await _repository.AddAsync(formMPositionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMPositionActualModel>(formMPositionActual);
        }
    }
}
