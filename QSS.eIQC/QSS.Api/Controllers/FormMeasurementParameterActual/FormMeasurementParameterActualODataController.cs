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
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMeasurementParameterActual Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("FormMeasurementParameterActual")]

    public class FormMeasurementParameterActualODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public FormMeasurementParameterActualODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a FormMeasurementParameterActual list
        /// </summary>
        /// <returns>An queryable object of FormMeasurementParameterActualModel, <see cref="FormMeasurementParameterActualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<FormMeasurementParameterActualModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.FormMeasurementParameterActual.ProjectToExpand<FormMeasurementParameterActualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of FormMeasurementParameterActuals that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of FormMeasurementParameterActualModel,  <see cref="FormMeasurementParameterActualModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<FormMeasurementParameterActualModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.FormMeasurementParameterActual.Where(d => d.Id == id).ProjectToExpand<FormMeasurementParameterActualModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
