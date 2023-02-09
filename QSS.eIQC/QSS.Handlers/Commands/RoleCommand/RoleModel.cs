using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.RoleCommand
{
    /// <summary>
    /// Representation model for Role entity
    /// </summary>
    public class RoleModel : BaseStausModel<int>
    {
        /// <summary>
        /// Role Name
        /// </summary>
        public string Name { get; set; }

        public int? RoleEnumId { get; set; }

        public RoleEnumModel RoleEnum { get; set; }

        /// <summary>
        /// Get or set PermissionTypeIds property
        /// </summary>
        public virtual List<int> PermissionTypeIds { get; set; }

    }
}
