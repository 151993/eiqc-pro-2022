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
using QSS.eIQC.Handlers.Commands.UserCustomerCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// UserCustomer Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("UserCustomer")]

    public class UserCustomerODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UserCustomerODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a UserCustomer list
        /// </summary>
        /// <returns>An queryable object of UserCustomerModel, <see cref="UserCustomerModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<UserCustomerModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.UserCustomer.ProjectToExpand<UserCustomerModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();

        }


        /// <summary>
        /// OData API to return a collection of UserCustomers that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <returns>An queryable object of UserCustomerModel,  <see cref="UserCustomerModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<UserCustomerModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.UserCustomer.Where(d => d.Id == id).ProjectToExpand<UserCustomerModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
