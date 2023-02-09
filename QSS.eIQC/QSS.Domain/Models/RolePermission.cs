using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RolePermission : PersistentObjectWithUpdate<int>
    {
        /// <summary>
        /// 
        /// </summary>
        public int RoleId { get; set; }

        [Column("PermissionTypeId")]
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Role Role { get; set; }
    }
}
