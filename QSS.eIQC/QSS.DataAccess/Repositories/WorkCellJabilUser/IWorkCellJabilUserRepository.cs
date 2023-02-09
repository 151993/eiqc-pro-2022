using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  MaterialGroup User
    /// </summary>
    public interface IWorkCellJabilUserRepository
    {
        void AddWorkCellUsers(WorkCellUser workCellUser, List<int> userIds);
        void RemoveWorkCellUsers(int workCellUserId, List<int> userIds);
    }
}
