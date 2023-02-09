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
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormFunPara Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierFormFunPara")]

    public class SupplierFormFunParaODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierFormFunParaODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a SupplierFormFunPara list
        /// </summary>
        /// <returns>An queryable object of SupplierFormFunParaModel, <see cref="SupplierFormFunParaModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SupplierFormFunParaModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.SupplierFormFunPara.ProjectToExpand<SupplierFormFunParaModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of SupplierFormFunParas that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of SupplierFormFunParaModel,  <see cref="SupplierFormFunParaModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<SupplierFormFunParaModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.SupplierFormFunPara.Where(d => d.Id == id).ProjectToExpand<SupplierFormFunParaModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
