/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Add
{
    /// <summary>
    /// Command Handler for Add DateCode operation
    /// </summary>
    public class AddPartDateCodeCommandHandler : IRequestHandler<AddPartDateCodeModel, PartDateCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IPartDateCodeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPartDateCodeCommandHandler(QSSContext context, IPartDateCodeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PartDateCode entity
        /// </summary>
        /// <param name="request">Add PartDateCode model, <see cref="AddPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PartDateCode model</returns>
        public async Task<PartDateCodeModel> Handle(AddPartDateCodeModel request, CancellationToken cancellationToken)
        {
            var partDateCode = _mapper.Map<PartDateCode>(request);            

            await _repository.AddAsync(partDateCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartDateCodeModel>(partDateCode);
        }
    }
}
