using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.MaterialGroupCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("ParameterManagementTypes")]
    public class ParameterManagementTypeODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ParameterManagementTypeODataController(IQSSContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a ParameterManagement Type list
        /// </summary>
        /// <returns>An queryable object of ParameterManagementTypeModel, <see cref="ParameterManagementTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<ParameterManagementTypeModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.ParameterManagementType.ProjectToExpand<ParameterManagementTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of ParameterManagements that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of ParameterManagementTypeModel,  <see cref="ParameterManagementTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<ParameterManagementTypeModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.ParameterManagementType.Where(d => d.Id == id).ProjectToExpand<ParameterManagementTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
