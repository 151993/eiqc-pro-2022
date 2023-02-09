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
    /// Repository for SiteWorkCell, provides Add, Update and Delete operations
    /// </summary>
    public class SiteWorkCellRepository : Repository<SiteWorkCell, int>, ISiteWorkCellRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SiteWorkCellRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of WorkCells associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedWorkCellIds">List of WorkCell Ids to be added</param>
        public void AddSiteWorkCells(Site site, List<int> workCellIds)
        {
            if (workCellIds != null && workCellIds.IsAny())
            {
                AddRange(workCellIds.Select(r =>
                   new SiteWorkCell()
                   {
                       Site = site,
                       WorkCellId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the SiteWorkCell with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">siteId</param>
        /// <param name="WorkCellIds">List of WorkCell Ids to be deleted</param>
        public void RemoveSiteWorkCells(int siteId, List<int> workCellIds)
        {
            if (workCellIds != null && workCellIds.IsAny())
            {
                var SiteWorkCells = Context.Set<SiteWorkCell>()
                                .Where(s => s.SiteId == siteId)
                                .Where(d => workCellIds.Contains(d.WorkCellId))
                                .ToList();


                if (!SiteWorkCells.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SiteWorkCellDoesNotExists(siteId));
                }

                RemoveRange(SiteWorkCells);
            }
        }
    }
}
