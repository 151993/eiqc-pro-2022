/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Update
{
    /// <summary>
    /// Command Handler for Update DispositionType operation
    /// </summary>
    public class UpdateDispositionTypeCommandHandler : IRequestHandler<UpdateDispositionTypeModel, DispositionTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IDispositionTypeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateDispositionTypeCommandHandler(QSSContext context, IDispositionTypeRepository dispositionTypeRepository, IMapper mapper)
        {
            _context = context;
            _repository = dispositionTypeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update DispositionType entity
        /// </summary>
        /// <param name="request">Input Update DispositionType model, <see cref="UpdateDispositionTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated DispositionType model</returns>
        public async Task<DispositionTypeModel> Handle(UpdateDispositionTypeModel request, CancellationToken cancellationToken)
        {
            var dispositionType = _mapper.Map<DispositionType>(request);          

            await _repository.UpdateAsync(dispositionType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DispositionTypeModel>(dispositionType);
        }
    }
}
