/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Add
{
    /// <summary>
    /// Command Handler for Add Group operation
    /// </summary>
    public class AddGroupCommandHandler : IRequestHandler<AddGroupModel, GroupModel>
    {
        private readonly QSSContext _context;
        private readonly IGroupRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddGroupCommandHandler(QSSContext context, IGroupRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Group entity
        /// </summary>
        /// <param name="request">Add Group model, <see cref="AddGroupModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Group model</returns>
        public async Task<GroupModel> Handle(AddGroupModel request, CancellationToken cancellationToken)
        {
            var group = _mapper.Map<Group>(request);            

            await _repository.AddAsync(group, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GroupModel>(group);
        }
    }
}
