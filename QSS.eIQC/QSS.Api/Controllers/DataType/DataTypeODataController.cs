
using System.Linq;
using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.DataTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("DataType")]
    public class DataTypeODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public DataTypeODataController(IQSSContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a DataType Type list
        /// </summary>
        /// <returns>An queryable object of DataTypeTypeModel, <see cref="DataTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<DataTypeModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.DataType.ProjectToExpand<DataTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of DataTypes that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of DataTypeTypeModel,  <see cref="DataTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<DataTypeModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.DataType.Where(d => d.Id == id).ProjectToExpand<DataTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
