using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
}

/// <summary>
/// Repository for TestReportCommodity, provides Add, Update and Delete operations
/// </summary>
public class TestReportCommodityRepository : Repository<TestReportCommodity, int>, ITestReportCommodityRepository
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="context"><see cref="QSSContext"/></param>
    public TestReportCommodityRepository(QSSContext context) : base(context)
    {
    }

    /// <summary>
    /// Adds range of Commoditys associated with TestReport in database.
    /// </summary>
    /// <param name="TestReport">TestReport object</param>
    /// <param name="addedcommodityIds">List of Commodity Ids to be added</param>
    public void AddTestReportCommodities(TestReport testReport, List<int> commodityIds)
    {
        if (commodityIds != null && commodityIds.IsAny())
        {
            AddRange(commodityIds.Select(r =>
               new TestReportCommodity()
               {
                   TestReport = testReport,
                   CommodityId = r
               }
            ));
        }
    }

    /// <summary>
    /// Checks if the TestReportCommodity with id presents in database, if found then deletes from database.
    /// </summary>
    /// <param name="id">TestReport Id</param>
    /// <param name="commodityIds">List of Commodity Ids to be deleted</param>
    public void RemoveTestReportCommodities(int TestReportId, List<int> commodityIds)
    {
        if (commodityIds != null && commodityIds.IsAny())
        {
            var testReportCommoditys = Context.Set<TestReportCommodity>()
                            .Where(s => s.TestReportId == TestReportId)
                            .Where(d => commodityIds.Contains(d.CommodityId))
                            .ToList();


            if (!testReportCommoditys.IsAny())
            {
                throw new Exception(Constants.ErrorMessage.TestReportCommodityDoesNotExists(TestReportId));
            }

            RemoveRange(testReportCommoditys);
        }
    }
}

