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
using QSS.eIQC.Handlers.Commands.DefectSectionCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DefectSection Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("DefectSection")]

    public class DefectSectionODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public DefectSectionODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a DefectSection list
        /// </summary>
        /// <returns>An queryable object of DefectSectionModel, <see cref="DefectSectionModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<DefectSectionModel> Get(ODataQueryOptions oDataQueryOptions)

        {
            return Context.DefectSection.ProjectToExpand<DefectSectionModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of DefectSections that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of DefectSectionModel,  <see cref="DefectSectionModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<DefectSectionModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.DefectSection.Where(d => d.Id == id).ProjectToExpand<DefectSectionModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }




    }
}
