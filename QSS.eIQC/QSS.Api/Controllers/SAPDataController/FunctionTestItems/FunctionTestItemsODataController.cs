using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.SAPModels;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("FunctionTestItems")]
    public class FunctionTestItemsODataController : BaseODataController
    {
        private readonly ISAPHanaClient _sapHanaClient;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="sapHanaClient">Injected instance of ISAPPartService on runtime</param>
        public FunctionTestItemsODataController(IQSSContext context, IMapper mapper, ISAPHanaClient sapHanaClient) : base(context, mapper)
        {
            _sapHanaClient = sapHanaClient;
        }



        /// <summary>
        /// OData API to retrieve a Function Test Items list
        /// </summary>
        /// <returns>An queryable object of FunctionTestItems, <see cref="FunctionTestItems"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<FunctionTestItems> GetFunctionTestItems(ODataQueryOptions oDataQueryOptions)
        {
            var result = _sapHanaClient.GetFunctionTestItems().AsQueryable();

            return result;
        }
    }
}
