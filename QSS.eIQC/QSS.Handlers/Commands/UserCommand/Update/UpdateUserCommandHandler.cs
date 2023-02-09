using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.UserCommand.Update
{
    /// <summary>
    /// Command Handler for Update User operation
    /// </summary>
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserModel, UserModel>
    {
        private readonly QSSContext _context;
        private readonly IUserRepository _repository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateUserCommandHandler(QSSContext context, IUserRepository repository, IUserRoleRepository userRoleRepository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update User entity
        /// </summary>
        /// <param name="request">Input Update User model, <see cref="UpdateUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated User model</returns>
        public async Task<UserModel> Handle(UpdateUserModel request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            
            _userRoleRepository.AddUserRoles(user, request.AddedRoleIds);

            _userRoleRepository.RemoveUserRoles(user.Id, request.RemovedRoleIds);

            await _repository.UpdateAsync(user, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<UserModel>(user);
        }
    }
}
