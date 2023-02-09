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
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartInspectionDrawing Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("PartInspectionDrawing")]

    public class PartInspectionDrawingODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public PartInspectionDrawingODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a PartInspectionDrawing list
        /// </summary>
        /// <returns>An queryable object of PartInspectionDrawingModel, <see cref="PartInspectionDrawingModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<PartInspectionDrawingModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartInspectionDrawing.ProjectToExpand<PartInspectionDrawingModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of PartInspectionDrawings that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of PartInspectionDrawingModel,  <see cref="PartInspectionDrawingModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<PartInspectionDrawingModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartInspectionDrawing.Where(d => d.Id == id).ProjectToExpand<PartInspectionDrawingModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
