

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
    /// Repository for MaterialGroupJabilUser, provides Add, Update and Delete operations
    /// </summary>
    public class WorkCellJabilUserRepository : Repository<WorkCellJabilUser, int>, IWorkCellJabilUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public WorkCellJabilUserRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Users associated with MaterialGroup in database.
        /// </summary>
        /// <param name="MaterialGroup">MaterialGroup object</param>
        /// <param name="addeduserIds">List of User Ids to be added</param>
        public void AddWorkCellUsers(WorkCellUser workCellUser, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                AddRange(userIds.Select(r =>
                   new WorkCellJabilUser()
                   {
                       WorkCellUser = workCellUser,
                       UserId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the MaterialGroupJabilUser with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">MaterialGroup Id</param>
        /// <param name="userIds">List of User Ids to be deleted</param>
        public void RemoveWorkCellUsers(int workCellUserId, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                var materialGroupJabilUsers = Context.Set<WorkCellJabilUser>()
                                .Where(s => s.WorkCellUserId == workCellUserId)
                                .Where(d => userIds.Contains(d.UserId))
                                .ToList();


                if (!materialGroupJabilUsers.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.WorkCellJabilUserDoesNotExists(workCellUserId));
                }

                RemoveRange(materialGroupJabilUsers);
            }
        }
    }

}
