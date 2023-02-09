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
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ReceiveGoodsInfo Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("ReceiveGoodsInfo")]

    public class ReceiveGoodsInfoODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ReceiveGoodsInfoODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a ReceiveGoodsInfo list
        /// </summary>
        /// <returns>An queryable object of ReceiveGoodsInfoModel, <see cref="ReceiveGoodsInfoModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<ReceiveGoodsInfoModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.ReceiveGoodsInfo.ProjectToExpand<ReceiveGoodsInfoModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of ReceiveGoodsInfos that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions"></param>
        /// <returns>An queryable object of ReceiveGoodsInfoModel,  <see cref="ReceiveGoodsInfoModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<ReceiveGoodsInfoModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.ReceiveGoodsInfo.Where(d => d.Id == id).ProjectToExpand<ReceiveGoodsInfoModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
