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
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DefectType Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("DefectType")]

    public class DefectTypeODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public DefectTypeODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a DefectType list
        /// </summary>
        /// <returns>An queryable object of DefectTypeModel, <see cref="DefectTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<DefectTypeModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.DefectType.ProjectToExpand<DefectTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of DefectTypes that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of DefectTypeModel,  <see cref="DefectTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<DefectTypeModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.DefectType.Where(d => d.Id == id).ProjectToExpand<DefectTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }



        /// <summary>
        /// OData API to return a collection of DefectTypes that matches with the input
        /// </summary>
        /// <param name="defectSectionId"></param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of DefectTypeModel,  <see cref="DefectTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetDefectTypeNameBySection(defectSectionId={defectSectionId})")]
        public IQueryable<DefectTypeModel> GetDefectTypeNameBySection([FromODataUri] int defectSectionId, ODataQueryOptions oDataQueryOptions)
        {
            var defectManagement = Context.DefectManagement.Where(k => k.DefectSectionId == defectSectionId ).FirstOrDefault();
            if(defectManagement!=null)
            {
                return Context.DefectType.Where(d => d.DefectManagementId == defectManagement.Id && d.DefectManagement.Status==StatusType.Active)
                    .ProjectToExpand<DefectTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
            }
            else
            {
                return Context.DefectType.ProjectToExpand<DefectTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();

            }
            
        }
    }
}
