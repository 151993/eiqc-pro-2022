/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormType operation
    /// </summary>
    public class UpdateFormTypeCommandHandler : IRequestHandler<UpdateFormTypeModel, FormTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IFormTypeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormTypeCommandHandler(QSSContext context, IFormTypeRepository formTypeRepository, IMapper mapper)
        {
            _context = context;
            _repository = formTypeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormType entity
        /// </summary>
        /// <param name="request">Input Update FormType model, <see cref="UpdateFormTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormType model</returns>
        public async Task<FormTypeModel> Handle(UpdateFormTypeModel request, CancellationToken cancellationToken)
        {
            var formType = _mapper.Map<FormType>(request);          

            await _repository.UpdateAsync(formType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormTypeModel>(formType);
        }
    }
}
