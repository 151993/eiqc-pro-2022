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
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartBowTwistParameter Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("PartInspectionBowTwistParameter")]

    public class PartBowTwistParameterODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public PartBowTwistParameterODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a PartBowTwistParameter list
        /// </summary>
        /// <returns>An queryable object of PartBowTwistParameterModel, <see cref="PartInspectionBowTwistParameterModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<PartInspectionBowTwistParameterModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartInspectionBowTwistParameter.ProjectToExpand<PartInspectionBowTwistParameterModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of PartBowTwistParameters that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of PartBowTwistParameterModel,  <see cref="PartInspectionBowTwistParameterModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<PartInspectionBowTwistParameterModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartInspectionBowTwistParameter.Where(d => d.Id == id).ProjectToExpand<PartInspectionBowTwistParameterModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
