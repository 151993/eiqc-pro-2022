using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.MaterialGroupCommand;
using System.Linq;



namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// MaterialGroup Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("MaterialGroup")]

    public class MaterialGroupODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public MaterialGroupODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a User list
        /// </summary>
        /// <returns>An queryable object of MaterialGroupModel, <see cref="MaterialGroupModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<MaterialGroupModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.MaterialGroup.ProjectToExpand<MaterialGroupModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of MaterialGroup that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of MaterialGroupModel,  <see cref="MaterialGroupModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<MaterialGroupModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.MaterialGroup.Where(d =>d.Id == id).ProjectToExpand<MaterialGroupModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
