/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Update
{
    /// <summary>
    /// Command Handler for Update Form operation
    /// </summary>
    public class UpdateFormCommandHandler : IRequestHandler<UpdateFormModel, FormModel>
    {
        private readonly QSSContext _context;
        private readonly IFormRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormCommandHandler(QSSContext context, IFormRepository formRepository, IMapper mapper)
        {
            _context = context;
            _repository = formRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Form entity
        /// </summary>
        /// <param name="request">Input Update Form model, <see cref="UpdateFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Form model</returns>
        public async Task<FormModel> Handle(UpdateFormModel request, CancellationToken cancellationToken)
        {
            var form = _mapper.Map<Form>(request);          

            await _repository.UpdateAsync(form, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormModel>(form);
        }
    }
}
