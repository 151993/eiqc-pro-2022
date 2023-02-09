/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Update
{
    /// <summary>
    /// Command Handler for Update WorkCellUser operation
    /// </summary>
    public class UpdateWorkCellUserCommandHandler : IRequestHandler<UpdateWorkCellUserModel, WorkCellUserModel>
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
        public UpdateWorkCellUserCommandHandler(QSSContext context, IWorkCellUserRepository workCellUserRepository, IMapper mapper, IWorkCellJabilUserRepository workCellJabilUserRepository, IWorkCellDccUserRepository workCellDccUserRepository)
        {
            _context = context;
            _repository = workCellUserRepository;            
            _mapper = mapper;
            _workCellJabilUserRepository = workCellJabilUserRepository;
            _workCellDccUserRepository = workCellDccUserRepository;
        }

        /// <summary>
        /// Validates the input model and Update WorkCellUser entity
        /// </summary>
        /// <param name="request">Input Update WorkCellUser model, <see cref="UpdateWorkCellUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated WorkCellUser model</returns>
        public async Task<WorkCellUserModel> Handle(UpdateWorkCellUserModel request, CancellationToken cancellationToken)
        {
            var workCellUser = _mapper.Map<WorkCellUser>(request);

            _workCellJabilUserRepository.AddWorkCellUsers(workCellUser, request.AddedJabilUserIds);

            _workCellJabilUserRepository.RemoveWorkCellUsers(workCellUser.Id, request.RemovedJabilUserIds);

            _workCellDccUserRepository.AddWorkCellDccUsers(workCellUser, request.AddedDccUserIds);

            _workCellDccUserRepository.RemoveWorkCellDccUsers(workCellUser.Id, request.RemovedDccUserIds);

            await _repository.UpdateAsync(workCellUser, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<WorkCellUserModel>(workCellUser);
        }
    }
}
