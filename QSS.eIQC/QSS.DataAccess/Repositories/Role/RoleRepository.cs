using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for Role, provides Add, Update and Delete Role
    /// </summary>
    public class RoleRepository : BaseRepository<Role,int>, IRoleRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public RoleRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Role into database
        /// </summary>
        /// <param name="role">New entity of Role, <see cref="Role"/></param>
        /// <returns>Saved entity of Role, <see cref="Role"/></returns>
        public async Task<Role> AddAsync(Role role, string changeReason)
        {
            return await AddAsync(role, Constants.AuditLog.Title.AddRole(role.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Role with new values
        /// </summary>
        /// <param name="role">Updated entity of Role, <see cref="Role"/></param>
        /// <returns>Saved entity of Role, <see cref="Role"/></returns>
        public async Task<Role> UpdateAsync(Role role, string changeReason)
        {
            return await UpdateAsync(role, Constants.AuditLog.Title.EditRole(role.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Role with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Role, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteRole(role.Name), changeReason);

            return Remove(role);
        }
    }
}
