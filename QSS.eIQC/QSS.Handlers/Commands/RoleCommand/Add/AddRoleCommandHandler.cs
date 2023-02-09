using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Add
{
    /// <summary>
    /// Command Handler for Add Role operation
    /// </summary>
    public class AddRoleCommandHandler : IRequestHandler<AddRoleModel, RoleModel>
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
        public AddRoleCommandHandler(QSSContext context, IRoleRepository repository, IRolePermissionRepository rolePermissionRepository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _rolePermissionRepository = rolePermissionRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Role entity
        /// </summary>
        /// <param name="request">Add Role model, <see cref="AddRoleModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Role model</returns>
        public async Task<RoleModel> Handle(AddRoleModel request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Role>(request);

            _rolePermissionRepository.AddRolePermissions(role, request.Permissions);

            await _repository.AddAsync(role, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<RoleModel>(role);
        }
    }
}
