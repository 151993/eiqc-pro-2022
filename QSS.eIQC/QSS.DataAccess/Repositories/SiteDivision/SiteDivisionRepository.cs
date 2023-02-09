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
    /// Repository for SiteDivision, provides Add, Update and Delete operations
    /// </summary>
    public class SiteDivisionRepository : Repository<SiteDivision, int>, ISiteDivisionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SiteDivisionRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Divisions associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addeddivisionIds">List of Division Ids to be added</param>
        public void AddSiteDivisions(Site site, List<int> divisionIds)
        {
            if (divisionIds != null && divisionIds.IsAny())
            {
                AddRange(divisionIds.Select(r =>
                   new SiteDivision()
                   {
                       Site = site,
                       DivisionId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the SiteDivision with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">Site Id</param>
        /// <param name="divisionIds">List of Division Ids to be deleted</param>
        public void RemoveSiteDivisions(int siteId, List<int> divisionIds)
        {
            if (divisionIds != null && divisionIds.IsAny())
            {
                var SiteDivisions = Context.Set<SiteDivision>()
                                .Where(s => s.SiteId == siteId)
                                .Where(d => divisionIds.Contains((int)(d.DivisionId)))
                                .ToList();


                if (!SiteDivisions.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SiteDivisionDoesNotExists(siteId));
                }

                RemoveRange(SiteDivisions);
            }
        }
    }
}
