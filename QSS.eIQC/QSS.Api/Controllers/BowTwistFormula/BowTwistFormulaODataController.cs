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
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// BowTwistFormula Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("BowTwistFormula")]

    public class BowTwistFormulaODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public BowTwistFormulaODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a BowTwistFormula list
        /// </summary>
        /// <returns>An queryable object of BowTwistFormulaModel, <see cref="BowTwistFormulaModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<BowTwistFormulaModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.BowTwistFormula.ProjectToExpand<BowTwistFormulaModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of BowTwistFormulas that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of BowTwistFormulaModel,  <see cref="BowTwistFormulaModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<BowTwistFormulaModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.BowTwistFormula.Where(d => d.Id == id).ProjectToExpand<BowTwistFormulaModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
