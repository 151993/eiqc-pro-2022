
using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{

    /// <summary>
    /// Repository for MaterialGroupDccUser, provides Add, Update and Delete operations
    /// </summary>
    public class WorkCellDccUserRepository : Repository<WorkCellDccUser, int>, IWorkCellDccUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public WorkCellDccUserRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Users associated with MaterialGroup in database.
        /// </summary>
        /// <param name="WorkCell">WorkCell object</param>
        /// <param name="addeduserIds">List of User Ids to be added</param>
        public void AddWorkCellDccUsers(WorkCellUser workCellUser, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                AddRange(userIds.Select(r =>
                   new WorkCellDccUser()
                   {
                       WorkCellUser = workCellUser,
                       UserId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the MaterialGroupDccUser with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">MaterialGroup Id</param>
        /// <param name="userIds">List of User Ids to be deleted</param>
        public void RemoveWorkCellDccUsers(int workCellId, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                var workCellDccUsers = Context.Set<WorkCellDccUser>()
                                .Where(s => s.WorkCellUserId == workCellId)
                                .Where(d => userIds.Contains(d.UserId))
                                .ToList();


                if (!workCellDccUsers.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.WorkCellDccUserDoesNotExists(workCellId));
                }

                RemoveRange(workCellDccUsers);
            }
        }
    }
}
