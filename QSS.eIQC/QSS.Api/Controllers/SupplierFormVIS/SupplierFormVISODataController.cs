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
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormVIS Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierFormVIS")]

    public class SupplierFormVISODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierFormVISODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a SupplierFormVIS list
        /// </summary>
        /// <returns>An queryable object of SupplierFormVISModel, <see cref="SupplierFormVISModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SupplierFormVISModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.SupplierFormVIS.ProjectToExpand<SupplierFormVISModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of SupplierFormVISs that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of SupplierFormVISModel,  <see cref="SupplierFormVISModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<SupplierFormVISModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.SupplierFormVIS.Where(d => d.Id == id).ProjectToExpand<SupplierFormVISModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
