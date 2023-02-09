/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormPackaging operation
    /// </summary>
    public class UpdateFormPackagingCommandHandler : IRequestHandler<UpdateFormPackagingModel, FormPackagingModel>
    {
        private readonly QSSContext _context;
        private readonly IFormPackagingRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormPackagingCommandHandler(QSSContext context, IFormPackagingRepository formPackagingRepository, IMapper mapper)
        {
            _context = context;
            _repository = formPackagingRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormPackaging entity
        /// </summary>
        /// <param name="request">Input Update FormPackaging model, <see cref="UpdateFormPackagingModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormPackaging model</returns>
        public async Task<FormPackagingModel> Handle(UpdateFormPackagingModel request, CancellationToken cancellationToken)
        {
            var formPackaging = _mapper.Map<FormPackaging>(request);          

            await _repository.UpdateAsync(formPackaging, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormPackagingModel>(formPackaging);
        }
    }
}
