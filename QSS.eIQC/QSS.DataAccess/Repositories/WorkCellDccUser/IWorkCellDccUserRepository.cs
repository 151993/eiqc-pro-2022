

using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  MaterialGroup dcc User
    /// </summary>
    public interface IWorkCellDccUserRepository
    {
        void AddWorkCellDccUsers(WorkCellUser workCellUser, List<int> userIds);
        void RemoveWorkCellDccUsers(int workCellUserId, List<int> userIds);
    }
}
