using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for UserRole, provides Add, Update and Delete operations
    /// </summary>
    public class UserRoleRepository : Repository<UserRole,int>, IUserRoleRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public UserRoleRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Roles associated with User in database.
        /// </summary>
        /// <param name="user">User object</param>
        /// <param name="addedRoleIds">List of Role Ids to be added</param>
        public void AddUserRoles(User user, int roleId)
        {
            if(roleId > 0)
            {
                AddAsync(new UserRole()
                {
                    User = user,
                    RoleId = roleId
                });
            }
        }

        /// <summary>
        /// Checks if the UserRole with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">User Id</param>
        /// <param name="roleIds">List of Role Ids to be deleted</param>
        /// <returns>Returns instance of removed UserRole, <see cref="UserRole"/></returns>
        public void RemoveUserRoles(int userId, int roleId)
        {
            if (roleId > 0)
            {
                var userRoles = Context.Set<UserRole>()
                                .Where(s => s.UserId == userId && s.RoleId== roleId)
                                .ToList();


                if (!userRoles.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.UserRoleDoesNotExists(userId));
                }

                RemoveRange(userRoles);
            }
        }
    }
}
