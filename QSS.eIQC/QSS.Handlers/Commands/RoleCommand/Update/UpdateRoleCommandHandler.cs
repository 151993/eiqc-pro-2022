using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Update
{
    /// <summary>
    /// Command Handler for Update Role operation
    /// </summary>
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleModel, RoleModel>
    {
        private readonly QSSContext _context;
        private readonly IRoleRepository _repository;
        private readonly IRolePermissionRepository _rolePermissionRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateRoleCommandHandler(QSSContext context, IRoleRepository roleRepository, IRolePermissionRepository rolePermissionRepository, IMapper mapper)
        {
            _context = context;
            _repository = roleRepository;
            _rolePermissionRepository = rolePermissionRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Role entity
        /// </summary>
        /// <param name="request">Input Update Role model, <see cref="UpdateRoleModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Role model</returns>
        public async Task<RoleModel> Handle(UpdateRoleModel request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Role>(request);

            _rolePermissionRepository.AddRolePermissions(role, request.AddedPermissions);

            _rolePermissionRepository.RemoveRolePermissions(role.Id, request.RemovedPermissions);

            await _repository.UpdateAsync(role, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<RoleModel>(role);
        }
    }
}
