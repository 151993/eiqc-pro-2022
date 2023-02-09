using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site WorkCell 
    /// </summary>
    public interface IWorkCellSiteRepository
    {
        void AddWorkCellSites(WorkCell workCell, List<int> siteIds);
        void RemoveWorkCellSites(int workCellId, List<int> siteIds);
    }
}
