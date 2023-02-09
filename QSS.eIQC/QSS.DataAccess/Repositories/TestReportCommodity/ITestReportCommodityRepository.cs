using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for TestReport Commodity 
    /// </summary>
    public interface ITestReportCommodityRepository
    {
        void AddTestReportCommodities(TestReport testReport, List<int> commodityIds);
        void RemoveTestReportCommodities(int testReportId, List<int> commodityIds);
    }
}
