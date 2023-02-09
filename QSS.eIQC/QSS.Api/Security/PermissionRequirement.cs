using QSS.eIQC.Domain.Enums;
using Microsoft.AspNetCore.Authorization;

namespace QSS.Security
{
    public class PermissionRequirement : IAuthorizationRequirement
    {

        public PermissionType Permission { get; set; }

        public PermissionRequirement(PermissionType permissionType)
        {
            Permission = permissionType;
        }
    }
}
