/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Update
{
    /// <summary>
    /// Command Handler for Update PartCAF operation
    /// </summary>
    public class UpdatePartCAFCommandHandler : IRequestHandler<UpdatePartCAFModel, PartCAFModel>
    {
        private readonly QSSContext _context;
        private readonly IPartCAFRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePartCAFCommandHandler(QSSContext context, IPartCAFRepository partCAFRepository, IMapper mapper)
        {
            _context = context;
            _repository = partCAFRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update PartCAF entity
        /// </summary>
        /// <param name="request">Input Update PartCAF model, <see cref="UpdatePartCAFModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated PartCAF model</returns>
        public async Task<PartCAFModel> Handle(UpdatePartCAFModel request, CancellationToken cancellationToken)
        {
            var partCAF = _mapper.Map<PartCAF>(request);          

            await _repository.UpdateAsync(partCAF, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartCAFModel>(partCAF);
        }
    }
}
