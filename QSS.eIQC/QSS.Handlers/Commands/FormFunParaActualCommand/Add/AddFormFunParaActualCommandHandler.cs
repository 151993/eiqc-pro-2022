/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormFunParaActual operation
    /// </summary>
    public class AddFormFunParaActualCommandHandler : IRequestHandler<AddFormFunParaActualModel, FormFunParaActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormFunParaActualRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormFunParaActualCommandHandler(QSSContext context, IFormFunParaActualRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormFunParaActual entity
        /// </summary>
        /// <param name="request">Add FormFunParaActual model, <see cref="AddFormFunParaActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormFunParaActual model</returns>
        public async Task<FormFunParaActualModel> Handle(AddFormFunParaActualModel request, CancellationToken cancellationToken)
        {
            var formFunParaActual = _mapper.Map<FormFunParaActual>(request);            

            await _repository.AddAsync(formFunParaActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormFunParaActualModel>(formFunParaActual);
        }
    }
}
