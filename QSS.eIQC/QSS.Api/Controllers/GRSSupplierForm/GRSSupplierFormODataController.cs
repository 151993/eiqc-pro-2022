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
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// GRSSupplierForm Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("GRSSupplierForm")]

    public class GRSSupplierFormODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public GRSSupplierFormODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a GRSSupplierForm list
        /// </summary>
        /// <returns>An queryable object of GRSSupplierFormModel, <see cref="GRSSupplierFormModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<GRSSupplierFormModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.GRSSupplierForm.ProjectToExpand<GRSSupplierFormModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of GRSSupplierForm that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of GRSSupplierFormModel,  <see cref="GRSSupplierFormModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<GRSSupplierFormModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.GRSSupplierForm.Where(d => d.Id == id).ProjectToExpand<GRSSupplierFormModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
