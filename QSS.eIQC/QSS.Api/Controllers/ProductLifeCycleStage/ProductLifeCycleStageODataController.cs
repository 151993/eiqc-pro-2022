
using System.Linq;
using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.ProductLifeCycleStageCommand;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("ProductLifeCycleStage")]
    public class ProductLifeCycleStageODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ProductLifeCycleStageODataController(IQSSContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a ProductLifeCycleStage Type list
        /// </summary>
        /// <returns>An queryable object of ProductLifeCycleStageTypeModel, <see cref="ProductLifeCycleStageModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<ProductLifeCycleStageModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.ProductLifeCycleStage.ProjectToExpand<ProductLifeCycleStageModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of ProductLifeCycleStages that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of ProductLifeCycleStageTypeModel,  <see cref="ProductLifeCycleStageModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<ProductLifeCycleStageModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.ProductLifeCycleStage.Where(d => d.Id == id).ProjectToExpand<ProductLifeCycleStageModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}

