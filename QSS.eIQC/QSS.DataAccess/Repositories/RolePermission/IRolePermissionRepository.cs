using QSS.eIQC.Domain.Models;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Role
    /// </summary>
    public interface IRolePermissionRepository : IBaseRepository<RolePermission,int>
    {
        void AddRolePermissions(Role role, List<PermissionType> permissionTypes);
        void RemoveRolePermissions(int roleId, List<PermissionType> permissionTypes);
    }
}
