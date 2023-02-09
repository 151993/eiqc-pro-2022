using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddRoleModel : BaseCommand, IRequest<RoleModel>
    {
        /// <summary>
		/// Get or set Name property
		/// </summary>
		public string Name { get; set; }

        public int? RoleEnumId { get; set; }

        /// <summary>
        /// Get or set Permissions property
        /// </summary>
        public List<PermissionType> Permissions { get; set; }
    }
}
