using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.ManagerCommand;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand;
using QSS.eIQC.Handlers.Commands.SupplierCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCommand
{
    public class JabilUserModel : BaseStausModel<int>
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public int? UserTypeId { get; set; }
        public bool AllowNotification { get; set; }
        public string DisplayName { set; get; }
        public int? ManagerId { set; get; }
        public int? DepartmentId { set; get; }
        public virtual IEnumerable<RoleModel> Roles { get; set; }
        public virtual ManagerModel Manager { get; set; }
        public virtual DepartmentModel Department { get; set; }
        public int? SiteId { get; set; }
        public virtual SiteModel Site { get; set; }
        public string Phone { get; set; }
        public int? SupplierId { get; set; }
        public virtual SupplierModel Supplier { get; set; }

    }
}
