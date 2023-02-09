/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormLPositionActual operation
    /// </summary>
    public class UpdateFormLPositionActualCommandHandler : IRequestHandler<UpdateFormLPositionActualModel, FormLPositionActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormLPositionActualCommandHandler(QSSContext context, IFormLPositionActualRepository formLPositionActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = formLPositionActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormLPositionActual entity
        /// </summary>
        /// <param name="request">Input Update FormLPositionActual model, <see cref="UpdateFormLPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormLPositionActual model</returns>
        public async Task<FormLPositionActualModel> Handle(UpdateFormLPositionActualModel request, CancellationToken cancellationToken)
        {
            var formLPositionActual = _mapper.Map<FormLPositionActual>(request);          

            await _repository.UpdateAsync(formLPositionActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormLPositionActualModel>(formLPositionActual);
        }
    }
}
