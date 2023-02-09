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
    /// Repository for WorkCellSite, provides Add, Update and Delete operations
    /// </summary>
    public class WorkCellSiteRepository : Repository<WorkCellSite, int>, IWorkCellSiteRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public WorkCellSiteRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of WorkCells associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedsiteIds">List of WorkCell Ids to be added</param>
        public void AddWorkCellSites(WorkCell workCell, List<int> siteIds)
        {
            if (siteIds != null && siteIds.IsAny())
            {
                AddRange(siteIds.Select(r =>
                   new WorkCellSite()
                   {
                       WorkCell = workCell,
                       SiteId = r,
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the WorkCellSite with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">siteId</param>
        /// <param name="siteIds">List of WorkCell Ids to be deleted</param>
        public void RemoveWorkCellSites(int workCellId, List<int> siteIds)
        {
            if (siteIds != null && siteIds.IsAny())
            {
                var workCellSites = Context.Set<WorkCellSite>()
                                .Where(s => s.WorkCellId == workCellId)
                                .Where(d => siteIds.Contains(d.SiteId))
                                .ToList();


                if (!workCellSites.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.WorkCellSiteDoesNotExists(workCellId));
                }

                RemoveRange(workCellSites);
            }
        }
    }
}
