/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Update
{
    /// <summary>
    /// Command Handler for Update CompletedGRS operation
    /// </summary>
    public class UpdateCompletedGRSCommandHandler : IRequestHandler<UpdateCompletedGRSModel, CompletedGRSModel>
    {
        private readonly QSSContext _context;
        private readonly ICompletedGRSRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateCompletedGRSCommandHandler(QSSContext context, ICompletedGRSRepository completedGRSRepository, IMapper mapper)
        {
            _context = context;
            _repository = completedGRSRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update CompletedGRS entity
        /// </summary>
        /// <param name="request">Input Update CompletedGRS model, <see cref="UpdateCompletedGRSModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated CompletedGRS model</returns>
        public async Task<CompletedGRSModel> Handle(UpdateCompletedGRSModel request, CancellationToken cancellationToken)
        {
            var completedGRS = _mapper.Map<CompletedGRS>(request);          

            await _repository.UpdateAsync(completedGRS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CompletedGRSModel>(completedGRS);
        }
    }
}
