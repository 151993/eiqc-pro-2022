/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Add
{
    /// <summary>
    /// Command Handler for Add WorkCellUser operation
    /// </summary>
    public class AddWorkCellUserCommandHandler : IRequestHandler<AddWorkCellUserModel, WorkCellUserModel>
    {
        private readonly QSSContext _context;
        private readonly IWorkCellUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWorkCellJabilUserRepository _workCellJabilUserRepository;
        private readonly IWorkCellDccUserRepository _workCellDccUserRepository;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddWorkCellUserCommandHandler(QSSContext context, IWorkCellUserRepository repository, IMapper mapper, IWorkCellJabilUserRepository workcellJabilUserRepository, IWorkCellDccUserRepository workcellDccUserRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _workCellJabilUserRepository = workcellJabilUserRepository;
            _workCellDccUserRepository = workcellDccUserRepository;
        }

        /// <summary>
        /// Validates the input model and Add new WorkCellUser entity
        /// </summary>
        /// <param name="request">Add WorkCellUser model, <see cref="AddWorkCellUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added WorkCellUser model</returns>
        public async Task<WorkCellUserModel> Handle(AddWorkCellUserModel request, CancellationToken cancellationToken)
        {
            var workCellUser = _mapper.Map<WorkCellUser>(request);

            _workCellJabilUserRepository.AddWorkCellUsers(workCellUser, request.AddedJabilUserIds);

            _workCellDccUserRepository.AddWorkCellDccUsers(workCellUser, request.AddedDccUserIds);

            await _repository.AddAsync(workCellUser, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<WorkCellUserModel>(workCellUser);
        }
    }
}
