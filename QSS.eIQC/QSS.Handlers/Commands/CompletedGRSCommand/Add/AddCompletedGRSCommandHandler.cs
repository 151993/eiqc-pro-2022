/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Add
{
    /// <summary>
    /// Command Handler for Add CompletedGRS operation
    /// </summary>
    public class AddCompletedGRSCommandHandler : IRequestHandler<AddCompletedGRSModel, CompletedGRSModel>
    {
        private readonly QSSContext _context;
        private readonly ICompletedGRSRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCompletedGRSCommandHandler(QSSContext context, ICompletedGRSRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new CompletedGRS entity
        /// </summary>
        /// <param name="request">Add CompletedGRS model, <see cref="AddCompletedGRSModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added CompletedGRS model</returns>
        public async Task<CompletedGRSModel> Handle(AddCompletedGRSModel request, CancellationToken cancellationToken)
        {
            var completedGRS = _mapper.Map<CompletedGRS>(request);            

            await _repository.AddAsync(completedGRS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CompletedGRSModel>(completedGRS);
        }
    }
}
