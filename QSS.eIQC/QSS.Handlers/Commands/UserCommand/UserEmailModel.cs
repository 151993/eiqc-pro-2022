using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCommand
{
    public class UserEmailModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string EmployeeId { get; set; }

        public string DisplayName { set; get; }

        public virtual User CreatedByUser { get; set; }

        public virtual List<RoleModel> Roles { get; set; }

    }
}
