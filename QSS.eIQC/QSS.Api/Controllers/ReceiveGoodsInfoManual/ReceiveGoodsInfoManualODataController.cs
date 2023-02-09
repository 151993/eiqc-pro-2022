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
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ReceiveGoodsInfoManual Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("ReceiveGoodsInfoManual")]

    public class ReceiveGoodsInfoManualODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ReceiveGoodsInfoManualODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a ReceiveGoodsInfoManual list
        /// </summary>
        /// <returns>An queryable object of ReceiveGoodsInfoManualModel, <see cref="ReceiveGoodsInfoManualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<ReceiveGoodsInfoManualModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.ReceiveGoodsInfoManual.ProjectToExpand<ReceiveGoodsInfoManualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of ReceiveGoodsInfoManuals that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of ReceiveGoodsInfoManualModel,  <see cref="ReceiveGoodsInfoManualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<ReceiveGoodsInfoManualModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.ReceiveGoodsInfoManual.Where(d => d.Id == id).ProjectToExpand<ReceiveGoodsInfoManualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
