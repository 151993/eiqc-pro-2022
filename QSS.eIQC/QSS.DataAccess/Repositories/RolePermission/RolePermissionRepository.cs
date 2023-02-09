using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using QSS.eIQC.Infrastucture.Core.Extensions;
using QSS.eIQC.Infrastucture.Core.Helper;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for RolePermission, provides Add, Update and Delete RolePermission
    /// </summary>
    public class RolePermissionRepository : BaseRepository<RolePermission, int>, IRolePermissionRepository
    {
        /// <summary>
        /// Store QSSContext, <see cref="QSSContext"/>
        /// </summary>
        private readonly QSSContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public RolePermissionRepository(QSSContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds range of Permissions associated with Role in database.
        /// </summary>
        /// <param name="role">Role object</param>
        /// <param name="permissionTypes">List of PermissionTypes to be added, <see cref="{PermissionType}/></param>
        public void AddRolePermissions(Role role, List<PermissionType> permissionTypes)
        {
            if (permissionTypes != null && permissionTypes.IsAny())
            {
                AddRange(permissionTypes.Select(p =>
                {
                    return new RolePermission()
                    {
                        PermissionType = p,
                        Role = role
                    };
                }));
            }
        }

        /// <summary>
        /// Checks if the RolePermission with RoleId and PermissionType presents in database, if found then deletes from database
        /// </summary>
        /// <param name="roleId">Role Id</param>
        /// <param name="permissionType">PermissionType, <see cref="{PermissionType}"/></param>
        public void RemoveRolePermissions(int roleId, List<PermissionType> permissionTypes)
        {
            if (permissionTypes != null && permissionTypes.IsAny())
            {
                var rolePermissions = _context.Set<RolePermission>()
                                .Where(rp => rp.RoleId == roleId)
                                .Where(rp => permissionTypes.Contains(rp.PermissionType))
                                .ToList();

                if (!rolePermissions.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.RolePermissionsDoesNotExists(roleId));
                }

                RemoveRange(rolePermissions);
            }
        }

    }
}
