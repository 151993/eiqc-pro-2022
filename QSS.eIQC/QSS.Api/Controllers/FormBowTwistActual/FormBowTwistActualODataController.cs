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
using QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormBowTwistActual Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("FormBowTwistActual")]

    public class FormBowTwistActualODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public FormBowTwistActualODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a FormBowTwistActual list
        /// </summary>
        /// <returns>An queryable object of FormBowTwistActualModel, <see cref="FormBowTwistActualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<FormBowTwistActualModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.FormBowTwistActual.ProjectToExpand<FormBowTwistActualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of FormBowTwistActuals that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of FormBowTwistActualModel,  <see cref="FormBowTwistActualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<FormBowTwistActualModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.FormBowTwistActual.Where(d => d.Id == id).ProjectToExpand<FormBowTwistActualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
