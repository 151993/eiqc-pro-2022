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
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.CommodityCommand;

namespace QSS.eIQC.Api.Controllers.Commodity
{
    [ODataRoutePrefix("Commodity")]
    public class CommodityODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public CommodityODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a CommodityModel list
        /// </summary>
        /// <returns>An queryable object of CommodityModel, <see cref="CommodityModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<CommodityModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Commodity.ProjectToExpand<CommodityModel>(Mapper.ConfigurationProvider, oDataQueryOptions)
                .AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of CommodityModel that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// /// <param name="oDataQueryOptions">Takes input id as a key</param>
        /// <returns>An queryable object of CommodityModel,  <see cref="CommodityModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<CommodityModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)

        {
            return Context.Commodity.Where(d => d.Id == id).ProjectToExpand<CommodityModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        /// <summary>
        /// OData api to retrieve a CommodityModel list with Part and Site numbers
        /// </summary>
        /// <returns>An queryable object of CommodityModel, <see cref="CommodityModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetCommoditiesWithPartAndSite")]
        public IQueryable<CommodityModel> GetCommoditiesWithPartAndSite(ODataQueryOptions oDataQueryOptions)
        {
            var result = (from cm in Context.Commodity
                          join cmps in Context.CommodityPartNumberSite on cm.Id equals cmps.CommodityId
                          select new CommodityModel()
                          {
                              SAPCommodityId = cm.SAPCommodityId,
                              CommodityValidFrom = cm.CommodityValidFrom,
                              CommodityValidTo = cm.CommodityValidTo,
                              Name = cm.Name,
                              Id = cm.Id,
                              Description = cm.Description,
                              SiteNo = cmps.SiteNo,
                              PART_NO = cmps.PartNumber,
                              IsEnabled = (cm.Status == StatusType.Active)
                          });

            var returnobj = result.ProjectToExpand<CommodityModel>(Mapper.ConfigurationProvider, oDataQueryOptions)
                .AsQueryable();

            return returnobj;
        }


        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetCommoditiesWithPartAndSiteForExport")]
        public async Task<IEnumerable<CommodityModel>> GetCommoditiesWithPartAndSiteForExport(ODataQueryOptions oDataQueryOptions)
        {
            var result = (from cm in Context.Commodity
                          join cmps in Context.CommodityPartNumberSite on cm.Id equals cmps.CommodityId
                          select new CommodityModel()
                          {
                              SAPCommodityId = cm.SAPCommodityId,
                              CommodityValidFrom = cm.CommodityValidFrom,
                              CommodityValidTo = cm.CommodityValidTo,
                              Name = cm.Name,
                              Id = cm.Id,
                              Description = cm.Description,
                              SiteNo = cmps.SiteNo,
                              PART_NO = cmps.PartNumber,
                              IsEnabled = (cm.Status == StatusType.Active)
                          });

            var returnobj = result.ProjectToExpand<CommodityModel>(Mapper.ConfigurationProvider, oDataQueryOptions)
                .ToList();

            return returnobj;
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetCommodityByPart(part={part},siteCode={siteCode})")]
        public IQueryable<CommodityModel> GetCommodityByPart([FromODataUri] string part, [FromODataUri] string siteCode, ODataQueryOptions oDataQueryOptions)
        {
            var result = (from cm in Context.Commodity
                          join cmps in Context.CommodityPartNumberSite on cm.Id equals cmps.CommodityId
                          where cmps.PartNumber == part && cmps.SiteNo == siteCode
                          select new CommodityModel()
                          {
                              SAPCommodityId = cm.SAPCommodityId,
                              CommodityValidFrom = cm.CommodityValidFrom,
                              CommodityValidTo = cm.CommodityValidTo,
                              Name = cm.Name,
                              Id = cm.Id,
                              Description = cm.Description,
                              SiteNo = cmps.SiteNo,
                              IsEnabled = (cm.Status == StatusType.Active)
                          }).Distinct();
           
            return result;



        }
    }
}