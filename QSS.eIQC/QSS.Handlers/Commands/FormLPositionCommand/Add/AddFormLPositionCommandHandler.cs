/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormLPositionCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormLPosition operation
    /// </summary>
    public class AddFormLPositionCommandHandler : IRequestHandler<AddFormLPositionModel, FormLPositionModel>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormLPositionCommandHandler(QSSContext context, IFormLPositionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormLPosition entity
        /// </summary>
        /// <param name="request">Add FormLPosition model, <see cref="AddFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormLPosition model</returns>
        public async Task<FormLPositionModel> Handle(AddFormLPositionModel request, CancellationToken cancellationToken)
        {
            var formLPosition = _mapper.Map<FormLPosition>(request);            

            await _repository.AddAsync(formLPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormLPositionModel>(formLPosition);
        }
    }
}
