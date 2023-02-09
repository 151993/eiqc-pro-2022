/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormFunParaActual operation
    /// </summary>
    public class UpdateFormFunParaActualCommandHandler : IRequestHandler<UpdateFormFunParaActualModel, FormFunParaActualModel>
    {
        private readonly QSSContext _context;
        private readonly IFormFunParaActualRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormFunParaActualCommandHandler(QSSContext context, IFormFunParaActualRepository formFunParaActualRepository, IMapper mapper)
        {
            _context = context;
            _repository = formFunParaActualRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormFunParaActual entity
        /// </summary>
        /// <param name="request">Input Update FormFunParaActual model, <see cref="UpdateFormFunParaActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormFunParaActual model</returns>
        public async Task<FormFunParaActualModel> Handle(UpdateFormFunParaActualModel request, CancellationToken cancellationToken)
        {
            var formFunParaActual = _mapper.Map<FormFunParaActual>(request);          

            await _repository.UpdateAsync(formFunParaActual, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormFunParaActualModel>(formFunParaActual);
        }
    }
}
