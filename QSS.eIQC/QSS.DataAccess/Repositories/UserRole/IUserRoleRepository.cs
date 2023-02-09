using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for UserRole 
    /// </summary>
    public interface IUserRoleRepository
    {
        void AddUserRoles(User user, int roleIds);
        void RemoveUserRoles(int userId, int roleIds);
    }
}
