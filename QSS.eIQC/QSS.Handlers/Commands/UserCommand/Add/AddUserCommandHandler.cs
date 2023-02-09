using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FluentValidation;
using AutoMapper;
using System.Linq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Helper.UserEmailNotification;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.Handlers.Commands.UserCommand;
namespace QSS.eIQC.Handlers.Commands.UserCommand.Add
{
    /// <summary>
    /// Command Handler for Add User operation
    /// </summary>
    public class AddUserCommandHandler : IRequestHandler<AddUserModel, JabilUserModel>
    {
        private readonly QSSContext _context;
        private readonly IUserRepository _repository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IMapper _mapper;
        private readonly IUserEmailNotificationHelper _emailHelper;
        private readonly IManagerRepository _managerRepository;
        private readonly IDepartmentRepository _departmentRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddUserCommandHandler(QSSContext context, IUserRepository repository, IUserRoleRepository userRoleRepository, IMapper mapper, IUserEmailNotificationHelper emailHelper, IManagerRepository managerRepository, IDepartmentRepository departmentRepository)
        {
            _context = context;
            _repository = repository;
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
            _emailHelper = emailHelper;
            _managerRepository = managerRepository;
            _departmentRepository = departmentRepository;
        }

        /// <summary>
        /// Validates the input model and Add new User entity
        /// </summary>
        /// <param name="request">Add User model, <see cref="AddUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added User model</returns>
        public async Task<JabilUserModel> Handle(AddUserModel request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            if (!string.IsNullOrEmpty(request.DepartmentName))
            {
                var isExistDepartment = await _departmentRepository.GetDepartmentDetailByName(request.DepartmentName);
                if (isExistDepartment == null)
                {
                    user = await _departmentRepository.AddUserDepartment(user, request.DepartmentName);
                }
                else
                {
                    user.DepartmentId = isExistDepartment.Id;
                }
            }           

            if (!string.IsNullOrEmpty(request.ManagerName))
            {
                var isExistManager = await _managerRepository.GetManagerDetailByName(request.ManagerName);
                if (isExistManager == null)
                {
                    user = await _managerRepository.AddUserManager(user, request.ManagerName);
                }
                else
                {
                    user.ManagerId = isExistManager.Id;
                }
            }

            

            _userRoleRepository.AddUserRoles(user, request.AddedRoleIds);

            await _repository.AddAsync(user, request.ChangeReason);

            _context.SaveChanges();

            //#region Send email notification

            //_emailHelper.SendEmailWhenNewUserAdded(_context.User.Include(x => x.CreatedByUser).Where(x => x.Id == user.Id).FirstOrDefault());
            //#endregion Send email notification

            return _mapper.Map<JabilUserModel>(user);
        }
    }
}
