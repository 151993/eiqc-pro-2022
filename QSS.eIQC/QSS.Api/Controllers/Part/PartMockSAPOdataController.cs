/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Part Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("PartMockSAPData")]

    public class PartMockSAPODataController : BaseODataController
    {

        private readonly ISAPHanaClient _sapHanaClient;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public PartMockSAPODataController(IQSSContext context, IMapper mapper, ISAPHanaClient sapHanaClient) : base(context, mapper)
        {
            _sapHanaClient = sapHanaClient;
        }

        /// <summary>
        /// OData API to retrieve a Part list
        /// </summary>
        /// <returns>An queryable object of PartModel, <see cref="SAPMockPartModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SAPMockPartModel> GetPartData(ODataQueryOptions oDataQueryOptions)
        {
            var result = _sapHanaClient.GetPartData().AsQueryable();

            return result;
        }

    }
}
