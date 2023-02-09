using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCommand.Add
{
    public class AddUserModel : BaseCommand, IRequest<JabilUserModel>
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int? UserTypeId { get; set; }

        public string EmployeeId { get; set; }

        public string ManagerName { get; set; }

        public string DepartmentName { get; set; }

        public int? ManagerId { set; get; }
        public int? DepartmentId { set; get; }
        public int SiteId { set; get; }
        public int AddedRoleIds { get; set; }
        public string Phone { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierId { get; set; }
    }
}
