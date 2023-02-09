using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Update
{
    /// <summary>
    /// Representation model for Update Role operation
    /// </summary>
    public class UpdateRoleModel : BaseUpdateCommand<int>, IRequest<RoleModel>
    {
        /// <summary>
		/// Get or set Name property
		/// </summary>
		public string Name { get; set; }

        public int? RoleEnumId { get; set; }

        /// <summary>
        /// Get or set AddedPermissions property
        /// </summary>
        public List<PermissionType> AddedPermissions { get; set; }

        /// <summary>
        /// Get or set RemovedPermissions property
        /// </summary>
        public List<PermissionType> RemovedPermissions { get; set; }
    }
}
