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
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierTestReport Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierVisualInspectionDefectType")]

    public class SupplierVisualInspectionDefectTypeODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierVisualInspectionDefectTypeODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a CertificateType list
        /// </summary>
        /// <returns>An queryable object of CertificateTypeModel, <see cref="SupplierVisualInspectionDefectTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SupplierVisualInspectionDefectTypeModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.SupplierVisualInspectionDefectType.ProjectToExpand<SupplierVisualInspectionDefectTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetSupplierVisualInspectionDefectTypeModelById(id={id},parameterManagementId={parameterManagementId})")]
        public IQueryable<SupplierVisualInspectionDefectTypeModel> GetSupplierVisualInspectionDefectTypeModelById([FromODataUri] int Id, [FromODataUri] int parameterManagementId, ODataQueryOptions oDataQueryOptions)
        {
            
            var pmcd = (from pm in Context.SupplierVisualInspection
                        join pmc in Context.SupplierVisualInspectionDefectType on pm.Id equals pmc.SupplierVisualInspectionId
                        join dt in Context.DefectType on pmc.DefectTypeId equals dt.Id
                        where pm.SupplierMeasurementSubmissionId == Id && pm.ParameterManagementId == parameterManagementId
                        select new SupplierVisualInspectionDefectTypeModel()
                        {
                            DefectQty = pmc.DefectQty,
                            SupplierVisualInspectionId = pmc.SupplierVisualInspectionId,
                            DefectTypeId = pmc.DefectTypeId,
                            Id = pmc.Id,
                            DefectTypeName = dt.DefectTypeName
                        }).Distinct();
            return (IQueryable<SupplierVisualInspectionDefectTypeModel>)pmcd.ToList().AsQueryable();
        }
    }
}
