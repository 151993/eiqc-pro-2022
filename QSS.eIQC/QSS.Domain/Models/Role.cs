using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Role entity model to map database Role table
    /// </summary>
    public class Role : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Role()
        {
            Permissions = new HashSet<RolePermission>();
            UserRole = new HashSet<UserRole>();
        }

        /// <summary>
		/// Get or set Name property
		/// </summary>
		[AuditLog]
        [Unique]
        public string Name { get; set; }

        public int? RoleEnumId { get; set; }

        [AuditLog(DisplayName = "Role", ValueField = "Name", MappingField = "RoleEnumId")]
        public RoleEnumModel RoleEnum { get; set; }

        public virtual ICollection<RolePermission> Permissions { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
