using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCommand.Update
{
    public class UpdateUserModel : BaseUpdateCommand<int>, IRequest<UserModel>
    {
        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User NTID / SamAccount
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Get or set EmployeeId property
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Get or set UserTypeId property
        /// </summary>
        public int? UserTypeId { get; set; }

        /// <summary>
        /// Get or set AddedRoleIds property
        /// </summary>
        public int AddedRoleIds { get; set; }

        /// <summary>
        /// Get or set RemovedRoleIds property
        /// </summary>
        public int RemovedRoleIds { get; set; }

        public int? ManagerId { set; get; }
        public int? DepartmentId { set; get; }
        public int SiteId { set; get; }
        public string Phone { get; set; }
        public int? SupplierId { get; set; }
    }
}
