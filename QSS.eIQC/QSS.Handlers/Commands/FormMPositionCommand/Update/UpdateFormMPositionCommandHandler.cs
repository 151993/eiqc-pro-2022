/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormMPositionCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormMPosition operation
    /// </summary>
    public class UpdateFormMPositionCommandHandler : IRequestHandler<UpdateFormMPositionModel, FormMPositionModel>
    {
        private readonly QSSContext _context;
        private readonly IFormMPositionRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormMPositionCommandHandler(QSSContext context, IFormMPositionRepository formMPositionRepository, IMapper mapper)
        {
            _context = context;
            _repository = formMPositionRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormMPosition entity
        /// </summary>
        /// <param name="request">Input Update FormMPosition model, <see cref="UpdateFormMPositionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormMPosition model</returns>
        public async Task<FormMPositionModel> Handle(UpdateFormMPositionModel request, CancellationToken cancellationToken)
        {
            var formMPosition = _mapper.Map<FormMPosition>(request);          

            await _repository.UpdateAsync(formMPosition, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormMPositionModel>(formMPosition);
        }
    }
}
