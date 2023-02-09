using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for User, provides Add, Update and Delete operations
 /// </summary>
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public UserRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new User into database
        /// </summary>
        /// <param name="user">New entity of User, <see cref="User"/></param>
        /// <returns>Saved entity of Department, <see cref="Department"/></returns>
        public async Task<User> AddAsync(User user,string changeReason)
        {
            if (string.IsNullOrWhiteSpace(user.EmployeeId))
            {
                user.EmployeeId = string.Empty;
            }

            return await AddAsync(user, Constants.AuditLog.Title.AddUser(user.Name), changeReason);
        }

        /// <summary>
        /// Updates existing User with new values
        /// </summary>
        /// <param name="User">Updated entity of Department, <see cref="User"/></param>
        /// <returns>Saved entity of User, <see cref="User"/></returns>
        public async Task UpdateAsync(User user, string changeReason)
        {
            if (string.IsNullOrWhiteSpace(user.EmployeeId))
            {
                user.EmployeeId = string.Empty;
            }

            await UpdateAsync(user, Constants.AuditLog.Title.EditUser(user.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Department with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Department, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var user = await ValidateExistsAndGetAsync(id);

            SetAuditLog(user, Constants.AuditLog.Title.DeleteUser(user.Name), changeReason);

            Remove(user);
        }
    }
}
