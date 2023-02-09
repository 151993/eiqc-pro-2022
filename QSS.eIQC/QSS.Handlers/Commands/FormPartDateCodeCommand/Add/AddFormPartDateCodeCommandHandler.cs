/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormPartDateCode operation
    /// </summary>
    public class AddFormPartDateCodeCommandHandler : IRequestHandler<AddFormPartDateCodeModel, FormPartDateCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IFormPartDateCodeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormPartDateCodeCommandHandler(QSSContext context, IFormPartDateCodeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormPartDateCode entity
        /// </summary>
        /// <param name="request">Add FormPartDateCode model, <see cref="AddFormPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormPartDateCode model</returns>
        public async Task<FormPartDateCodeModel> Handle(AddFormPartDateCodeModel request, CancellationToken cancellationToken)
        {
            var formPartDateCode = _mapper.Map<FormPartDateCode>(request);            

            await _repository.AddAsync(formPartDateCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormPartDateCodeModel>(formPartDateCode);
        }
    }
}
