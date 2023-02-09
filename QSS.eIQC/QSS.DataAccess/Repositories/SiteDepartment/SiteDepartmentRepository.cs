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
    /// Repository for SiteDepartment, provides Add, Update and Delete operations
    /// </summary>
    public class SiteDepartmentRepository : Repository<SiteDepartment, int>, ISiteDepartmentRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SiteDepartmentRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Departments associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDepartmentIds">List of Department Ids to be added</param>
        public void AddSiteDepartments(Site site, List<int> departmentIds)
        {
            if (departmentIds != null && departmentIds.IsAny())
            {
                AddRange(departmentIds.Select(r =>
                   new SiteDepartment()
                   {
                       Site = site,
                       DepartmentId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the SiteDepartment with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">siteId</param>
        /// <param name="DepartmentIds">List of Department Ids to be deleted</param>
        public void RemoveSiteDepartments(int siteId, List<int> departmentIds)
        {
            if (departmentIds != null && departmentIds.IsAny())
            {
                var SiteDepartments = Context.Set<SiteDepartment>()
                                .Where(s => s.SiteId == siteId)
                                .Where(d => departmentIds.Contains(d.DepartmentId))
                                .ToList();


                if (!SiteDepartments.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SiteDepartmentDoesNotExists(siteId));
                }

                RemoveRange(SiteDepartments);
            }
        }
    }
}
