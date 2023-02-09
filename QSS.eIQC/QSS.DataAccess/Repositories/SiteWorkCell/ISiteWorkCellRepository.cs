using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site WorkCell 
    /// </summary>
    public interface ISiteWorkCellRepository
    {
        void AddSiteWorkCells(Site site, List<int> workCellIds);
        void RemoveSiteWorkCells(int siteId, List<int> workCellIds);
    }
}
