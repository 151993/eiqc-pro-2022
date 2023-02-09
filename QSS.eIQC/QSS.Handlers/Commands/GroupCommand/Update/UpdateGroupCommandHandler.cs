/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Update
{
    /// <summary>
    /// Command Handler for Update Group operation
    /// </summary>
    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupModel, GroupModel>
    {
        private readonly QSSContext _context;
        private readonly IGroupRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateGroupCommandHandler(QSSContext context, IGroupRepository groupRepository, IMapper mapper)
        {
            _context = context;
            _repository = groupRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Group entity
        /// </summary>
        /// <param name="request">Input Update Group model, <see cref="UpdateGroupModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Group model</returns>
        public async Task<GroupModel> Handle(UpdateGroupModel request, CancellationToken cancellationToken)
        {
            var group = _mapper.Map<Group>(request);          

            await _repository.UpdateAsync(group, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GroupModel>(group);
        }
    }
}
