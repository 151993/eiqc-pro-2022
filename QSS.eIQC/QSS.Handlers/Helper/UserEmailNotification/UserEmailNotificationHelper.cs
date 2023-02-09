using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Helper.UserEmailNotification;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System.Linq;

namespace QSS.eIQC.Handlers.Helper
{
    public class UserEmailNotificationHelper : IUserEmailNotificationHelper
    {
        /// <summary>
        /// Store ApplicationConfigurationContext, <see cref="ApplicationConfigurationContext"/>
        /// </summary>
        private readonly QSSContext _context;

        /// <summary>
        /// Store IMapper, <see cref="IMapper"/>
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Store EmailNotificationHelper, <see cref="EmailNotificationHelper"/>
        /// </summary>
        private readonly IEmailNotificationHelper _emailNotificationHelper;

        public UserEmailNotificationHelper(QSSContext context, IMapper mapper, IEmailNotificationHelper emailNotificationHelper)
        {
            _context = context;
            _mapper = mapper;
            _emailNotificationHelper = emailNotificationHelper;
        }

        public void SendEmailWhenNewUserAdded(User user)
        {
            try
            {
                var userEmailModel = _mapper.Map<UserEmailModel>(user);

                // Send to all user(s) who have permission to create user
                var admins = _context.User
                    .Include(x => x.Roles)
                    .ThenInclude(x => x.Role)
                    .ThenInclude(x => x.Permissions)
                    .Where(u => u.AllowNotification)
                    .Where(u => u.Roles.Any(r =>
                        r.Role.Permissions.Any(rp =>
                            rp.PermissionType == PermissionType.AdminUserCanCreate)))
                    .Select(x => x.Email).ToList();


                _emailNotificationHelper.SendEmail(user, EmailTemplateEnum.User_Added, new EmailModel()
                {
                    To = admins
                });
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
