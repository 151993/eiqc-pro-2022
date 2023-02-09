using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Department 
    /// </summary>
    public interface ISiteDepartmentRepository
    {
        void AddSiteDepartments(Site site, List<int> departmentIds);
        void RemoveSiteDepartments(int siteId, List<int> departmentIds);
    }
}
