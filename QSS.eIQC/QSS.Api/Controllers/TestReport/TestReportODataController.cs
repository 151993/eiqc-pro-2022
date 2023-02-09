/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.TestReportCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// TestReport Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("TestReport")]

    public class TestReportODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public TestReportODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a TestReport list
        /// </summary>
        /// <returns>An queryable object of TestReportModel, <see cref="TestReportModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<TestReportModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.TestReport.ProjectToExpand<TestReportModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of TestReports that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of TestReportModel,  <see cref="TestReportModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<TestReportModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.TestReport.Where(d => d.Id == id).ProjectToExpand<TestReportModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }



        /// <summary>
        /// OData API to return a collection of TestReports that matches with the input
        /// </summary>
        /// <param name="commodityId">Takes input commodityId as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of TestReportModel,  <see cref="TestReportModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetTestReportByCommodity(commodityId={commodityId})")]
        public IQueryable<TestReportModel> GetTestReportByCommodity([FromODataUri] int commodityId, ODataQueryOptions oDataQueryOptions)
        {
            var matchingTestReport = from testReport in Context.TestReport
                                     join testReportCommodity in Context.TestReportCommodity on testReport.Id equals testReportCommodity.TestReportId
                                     where testReportCommodity.CommodityId == commodityId
                                     select new TestReportModel()
                                     {
                                         Id = testReportCommodity.TestReport.Id,
                                         CommodityId = testReportCommodity.CommodityId,
                                         Name = testReportCommodity.TestReport.Name,
                                         IsEnabled = testReportCommodity.TestReport.Status != StatusType.Active,
                                         IsChecked = (testReportCommodity.TestReport.Status == StatusType.Active)
                                     };
            return matchingTestReport.ToList().AsQueryable();
        }
    }
}
