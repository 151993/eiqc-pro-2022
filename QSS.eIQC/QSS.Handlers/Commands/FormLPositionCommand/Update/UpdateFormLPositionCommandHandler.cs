/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormLPositionCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormLPosition operation
    /// </summary>
    public class UpdateFormLPositionCommandHandler : IRequestHandler<UpdateFormLPositionModel, FormLPositionModel>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormLPositionCommandHandler(QSSContext context, IFormLPositionRepository formLPositionRepository, IMapper mapper)
        {
            _context = context;
            _repository = formLPositionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormLPosition entity
        /// </summary>
        /// <param name="request">Input Update FormLPosition model, <see cref="UpdateFormLPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormLPosition model</returns>
        public async Task<FormLPositionModel> Handle(UpdateFormLPositionModel request, CancellationToken cancellationToken)
        {
            var formLPosition = _mapper.Map<FormLPosition>(request);          

            await _repository.UpdateAsync(formLPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormLPositionModel>(formLPosition);
        }
    }
}
