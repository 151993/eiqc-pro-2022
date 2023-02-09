using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISiteDivisionRepository
    {
        void AddSiteDivisions(Site site, List<int> divisionIds);
        void RemoveSiteDivisions(int siteId, List<int> divisionIds);
    }
}
