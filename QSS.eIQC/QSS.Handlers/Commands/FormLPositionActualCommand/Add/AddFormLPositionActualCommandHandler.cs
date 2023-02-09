/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormLPositionActual operation
    /// </summary>
    public class AddFormLPositionActualCommandHandler : IRequestHandler<AddFormLPositionActualModel, FormLPositionActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormLPositionActualCommandHandler(QSSContext context, IFormLPositionActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormLPositionActual entity
        /// </summary>
        /// <param name="request">Add FormLPositionActual model, <see cref="AddFormLPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormLPositionActual model</returns>
        public async Task<FormLPositionActualModel> Handle(AddFormLPositionActualModel request, CancellationToken cancellationToken)
        {
            var formLPositionActual = _mapper.Map<FormLPositionActual>(request);            

            await _repository.AddAsync(formLPositionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormLPositionActualModel>(formLPositionActual);
        }
    }
}
