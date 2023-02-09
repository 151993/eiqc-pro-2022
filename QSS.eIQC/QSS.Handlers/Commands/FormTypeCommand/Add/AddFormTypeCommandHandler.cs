/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormType operation
    /// </summary>
    public class AddFormTypeCommandHandler : IRequestHandler<AddFormTypeModel, FormTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IFormTypeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormTypeCommandHandler(QSSContext context, IFormTypeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormType entity
        /// </summary>
        /// <param name="request">Add FormType model, <see cref="AddFormTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormType model</returns>
        public async Task<FormTypeModel> Handle(AddFormTypeModel request, CancellationToken cancellationToken)
        {
            var formType = _mapper.Map<FormType>(request);            

            await _repository.AddAsync(formType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormTypeModel>(formType);
        }
    }
}
