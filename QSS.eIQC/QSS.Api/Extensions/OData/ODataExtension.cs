using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;
using QSS.eIQC.Handlers.Commands;
using QSS.eIQC.Handlers.Commands.EmailTemplateCommand;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;

using QSS.eIQC.Handlers.Commands.RegionCommand;
using System;

using QSS.eIQC.Handlers.Commands.DivisionCommand;
using QSS.eIQC.Handlers.Commands.LocationCommand;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.ManagerCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand;
using QSS.eIQC.Handlers.Commands.BuyerCommand;
using QSS.eIQC.Handlers.Commands.CompletedGRSCommand;
using QSS.eIQC.Handlers.Commands.CustomerCommand;
using QSS.eIQC.Handlers.Commands.CTParameterCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand;
using QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand;
using QSS.eIQC.Handlers.Commands.GroupCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.GRSSAPResultCommand;
using QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand;
using QSS.eIQC.Handlers.Commands.ParameterTypeCommand;
using QSS.eIQC.Handlers.Commands.PCCodeCommand;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand;
using QSS.eIQC.Handlers.Commands.RosettaCommand;
using QSS.eIQC.Handlers.Commands.PartCAFCommand;
using QSS.eIQC.Handlers.Commands.ParameterCategoryCommand;
using QSS.eIQC.Handlers.Commands.DispositionTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand;
using QSS.eIQC.Handlers.Commands.InspectionCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand;
using QSS.eIQC.Handlers.Commands.GRSCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.InstrumentCommand;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand;
using QSS.eIQC.Handlers.Commands.PartCommand;
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.PartFunParameterCommand;
using QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.PartMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.PartMPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.FormCommand;
using QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.FormFunParaActualCommand;
using QSS.eIQC.Handlers.Commands.FormLPositionCommand;
using QSS.eIQC.Handlers.Commands.FormLPositionActualCommand;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand;
using QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand;
using QSS.eIQC.Handlers.Commands.FormCountParameterCommand;
using QSS.eIQC.Handlers.Commands.FormFunParaCommand;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.FormMicroSectionCommand;
using QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand;
using QSS.eIQC.Handlers.Commands.FormSAPParameterCommand;
using QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand;
using QSS.eIQC.Handlers.Commands.FormPackagingCommand;
using QSS.eIQC.Handlers.Commands.FormMPositionActualCommand;
using QSS.eIQC.Handlers.Commands.FormMPositionCommand;
using QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand;
using QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.FormStatusCommand;
using QSS.eIQC.Handlers.Commands.FormTestReportCommand;
using QSS.eIQC.Handlers.Commands.FormVISCommand;
using QSS.eIQC.Handlers.Commands.FormTypeCommand;
using QSS.eIQC.SAPHana.Services.SAPModels;
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.MaterialGroupCommand;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand;
using QSS.eIQC.Handlers.Commands.DataTypeCommand;
using QSS.eIQC.Handlers.Commands.ProductLifeCycleStageCommand;
using QSS.eIQC.Handlers.Commands.TestReportCommand;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.Handlers.Commands.WarPageCommand;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand;
using QSS.eIQC.Handlers.Commands.SupplierCommand;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand;
using QSS.eIQC.Handlers.Commands.PurchaseOrderCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand;
using QSS.eIQC.Handlers.Commands.DefectSectionCommand;
using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementCommand;
using QSS.eIQC.Handlers.Commands.SupplierFunctionVariableCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierDateCodeCommand;
using QSS.eIQC.Handlers.Commands.SAPSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierMPositionCommand;
using QSS.eIQC.Handlers.Commands.DimensionDefaultCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand;
using QSS.eIQC.Handlers.Commands.RoleEnumCommand;
using QSS.eIQC.Handlers.Commands.ChartTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierFailedQuantityCommand;
using QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierSpcChartCommand;

namespace QSS.eIQC.Api.Extensions.OData
{
	/// <summary>
	/// OData extension
	/// </summary>
	public static class ODataExtension
	{
		/// <summary>
		/// Generates the OData IEdm Models based on the DB Tables/Models
		/// </summary>
		/// <param name="serviceProvider"></param>
		/// <returns><see cref="IEdmModel"/></returns>
		/// <remarks>
		/// Just use models from handler to avoid issues. e.g. 
		/// </remarks>
		public static IEdmModel GetODataModels(IServiceProvider serviceProvider)
		{
			/* Configure OData */
			ODataModelBuilder builder = new ODataConventionModelBuilder(serviceProvider).EnableLowerCamelCase();
			//builder.EntityType<Base>();
			/* Configure OData Entity Sets based on the Query Models */
			
			builder.EntitySet<AuditLogModel>("AuditLog").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<AuditMetadataEntityModel>("AuditMetadataEntity").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<JabilUserModel>("User").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<DepartmentModel>("Department").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<RoleModel>("Role").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<EmailTemplateModel>("EmailTemplate").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<WorkCellModel>("WorkCell").EntityType.Count().Filter().OrderBy().Expand().Select(); 
			builder.EntitySet<RegionModel>("Region").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<DivisionModel>("Division").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<LocationModel>("Location").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CountryModel>("Country").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SiteModel>("Site").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ManagerModel>("Manager").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SiteUserModel>("SiteUser").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<BuyerModel>("Buyer").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CompletedGRSModel>("CompletedGRS").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CustomerModel>("Customer").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CTParameterModel>("CTParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormModel>("SupplierForm").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<UOMModel>("UOM").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormVISModel>("SupplierFormVIS").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<GoodsReceiveUserModel>("GoodsReceiveUser").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<GroupModel>("Group").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<InspectionToolsTypeModel>("InspectionToolsType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<InstrumentTypeModel>("InstrumentType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<GRSSAPResultModel>("GRSSAPResult").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<LotInspectionQtyModel>("LotInspectionQty").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ParameterTypeModel>("ParameterType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartCAFModel>("PartCAF").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PCCodeModel>("PCCode").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ReceiveGoodsInfoModel>("ReceiveGoodsInfo").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ReceiveGoodsInfoManualModel>("ReceiveGoodsInfoManual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<RosettaModel>("Rosetta").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ParameterCategoryModel>("ParameterCategory").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<DispositionTypeModel>("DispositionType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormCountParameterModel>("SupplierFormCountParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierTestReportModel>("SupplierTestReport").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormSAPParameterModel>("SupplierFormSAPParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormBowTwistParameterModel>("SupplierFormBowTwistParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormSpecialParameterModel>("SupplierFormSpecialParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormResultOrientedParameterModel>("SupplierFormResultOrientedParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormPackagingModel>("SupplierFormPackaging").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormPartDateCodeModel>("SupplierFormPartDateCode").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormBowTwistActualModel>("SupplierFormBowTwistActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormFunParaModel>("SupplierFormFunPara").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormFunParaActualModel>("SupplierFormFunParaActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormLPositionModel>("SupplierFormLPosition").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormLPositionActualModel>("SupplierFormLPositionActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMeasurementParameterModel>("SupplierFormMeasurementParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMeasurementParameterActualModel>("SupplierFormMeasurementParameterActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMicroSectionModel>("SupplierFormMicroSection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMicroSectionActualModel>("SupplierFormMicroSectionActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMPositionModel>("SupplierFormMPosition").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFormMPositionActualModel>("SupplierFormMPositionActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierAttachmentModel>("SupplierAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<InspectionModel>("Inspection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<InspectionToolsModel>("InspectionTools").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<InstrumentModel>("Instrument").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<GRSModel>("GRS").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SAPPartInspectionPlanModel>("SAPPartInspectionPlan").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PCCodeInspectionToolsTypeModel>("PCCodeInspectionToolsType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<GRSSupplierFormModel>("GRSSupplierForm").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartModel>("Part").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SAPMockPartModel>("PartMockSAPData").EntityType.Count().Filter().OrderBy().Expand().Select();			
			builder.EntitySet<PartInspectionBowTwistParameterModel>("PartInspectionBowTwistParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartCountParameterModel>("PartCountParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartDateCodeModel>("PartDateCode").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartFunParameterModel>("PartFunParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartLPositionToleranceModel>("PartLPositionTolerance").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartMeasurementParameterModel>("PartMeasurementParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartMicrosectionModel>("PartMicrosection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartMPositionToleranceModel>("PartMPositionTolerance").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartResultOrientedParameterModel>("PartResultOrientedParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartTestReportParameterModel>("PartTestReportParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormModel>("Form").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormBowTwistParameterModel>("FormBowTwistParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormCountParameterModel>("FormCountParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormFunParaModel>("FormFunPara").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormFunParaActualModel>("FormFunParaActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormLPositionModel>("FormLPosition").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormLPositionActualModel>("FormLPositionActual").EntityType.Count().Filter().OrderBy().Expand().Select(); 
			builder.EntitySet<FormMeasurementParameterModel>("FormMeasurementParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormMeasurementParameterActualModel>("FormMeasurementParameterActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormBowTwistActualModel>("FormBowTwistActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormMicroSectionModel>("FormMicroSection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormSpecialParameterModel>("FormSpecialParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormSAPParameterModel>("FormSAPParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormResultOrientedParameterModel>("FormResultOrientedParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormPartSAPFailedQtyModel>("FormPartSAPFailedQty").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormPartDateCodeModel>("FormPartDateCode").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormPackagingModel>("FormPackaging").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormMPositionActualModel>("FormMPositionActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormMPositionModel>("FormMPosition").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormMicroSectionActualModel>("FormMicroSectionActual").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormStatusModel>("FormStatus").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormTestReportModel>("FormTestReport").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormVISModel>("FormVIS").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FormTypeModel>("FormType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CommodityModel>("Commodity").EntityType.Count().Filter().OrderBy().Expand().Select();
			// builder.EntitySet<CommodityCategory>("CommodityCategory").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CommodityNames>("CommodityNames").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<FunctionTestItems>("FunctionTestItems").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<AppearanceInspectionItem>("InspectionItems").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<AttachmentModel>("Attachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<AdminCertificationModel>("AdminCertification").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<AdminCertificationAttachmentModel>("AdminCertificationAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<MaterialGroupModel>("MaterialGroup").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ParameterManagementModel>("ParameterManagement").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ParameterManagementTypeModel>("ParameterManagementTypes").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<DataTypeModel>("DataType").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ProductLifeCycleStageModel>("ProductLifeCycleStage").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<TestReportModel>("TestReport").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<ParameterTypeCodeModel>("ParameterTypeCode").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<WorkCellUserModel>("WorkCellUser").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<PartInspectionDrawingAttachmentModel>("PartInspectionDrawingAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartInspectionSpecAttachmentModel>("PartInspectionSpecAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartInspectionCertificationAttachmentModel>("PartInspectionCertificationAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SMSCommentAttachmentModel>("SMSCommentAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<PartDimensionModel>("PartDimension").EntityType.Count().Filter().OrderBy().Expand().Select();
			var getChartType = builder.EntityType<PartDimensionModel>().Collection.Function("GetChartTypeId");
			getChartType.Parameter<string>("parameterManagementId");
			getChartType.ReturnsCollectionFromEntitySet<PartDimensionModel>("GetChartTypeId");


			var getParameter = builder.EntityType<ParameterManagementModel>().Collection.Function("GetParameterManagementDataByCommodityId");
            getParameter.Parameter<int>("commodityId");
			getParameter.Parameter<string>("pcNames");
			getParameter.ReturnsCollectionFromEntitySet<ParameterManagementModel>("GetParameterManagementDataByCommodityId");

			var getCommodity = builder.EntityType<CommodityModel>().Collection.Function("GetCommodityByPart");
			getCommodity.Parameter<string>("part");
			getCommodity.Parameter<string>("siteCode");
			getCommodity.ReturnsCollectionFromEntitySet<CommodityModel>("GetCommodityByPart");

			var getWorkCell = builder.EntityType<WorkCellModel>().Collection.Function("GetWorkCellByUserAndSite");
			getWorkCell.Parameter<string>("userId");
			getWorkCell.Parameter<string>("siteId");
			getWorkCell.ReturnsCollectionFromEntitySet<WorkCellModel>("GetWorkCellByUserAndSite");


			var getCommoditiesWithPartAndSite = builder.EntityType<CommodityModel>().Collection.Function("GetCommoditiesWithPartAndSite");
			getCommoditiesWithPartAndSite.ReturnsCollectionFromEntitySet<CommodityModel>("GetCommoditiesWithPartAndSite");

			var getCommoditiesWithPartAndSiteForExport = builder.EntityType<CommodityModel>().Collection.Function("getCommoditiesWithPartAndSiteForExport");
			getCommoditiesWithPartAndSiteForExport.ReturnsCollectionFromEntitySet<CommodityModel>("getCommoditiesWithPartAndSiteForExport");

			var getTestReport = builder.EntityType<TestReportModel>().Collection.Function("GetTestReportByCommodity");
			getTestReport.Parameter<int>("commodityId");
			getTestReport.ReturnsCollectionFromEntitySet<TestReportModel>("GetTestReportByCommodity");

			builder.EntitySet<BowTwistFormulaModel>("BowTwistFormula").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<WarPageModel>("WarPage").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<DCCConfigurationModel>("DCCConfiguration").EntityType.Count().Filter().OrderBy().Expand().Select();

			//builder.EntitySet<PartManufacurePartNumberModel>("ManufacturePartNumbers").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<PartTestReportAttachmentModel>("PartTestReportAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CommodityCategoryModel>("CommodityCategory").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<CommodityClassification>("CommodityClassification");
			builder.EntitySet<SupplierModel>("Supplier").EntityType.Count().Filter().OrderBy().Expand().Select();
			var syncSupplierFromSAP = builder.EntityType<SupplierModel>().Collection.Function("SyncSupplierFromSAP");
			syncSupplierFromSAP.ReturnsCollectionFromEntitySet<SupplierModel>("SyncSupplierFromSAP");

			builder.EntitySet<SAPPartModel>("PartSAPData").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartInspectionDrawingModel>("PartInspectionDrawing").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<PartInspectionSpecificationModel>("PartInspectionSpecification").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<PurchaseOrderModel>("PurchaseOrder").EntityType.Count().Filter().OrderBy().Expand().Select();
			var syncPurchaseOrderFromSAP = builder.EntityType<PurchaseOrderModel>().Collection.Function("SyncPurchaseOrderFromSAP");
			syncPurchaseOrderFromSAP.ReturnsCollectionFromEntitySet<PurchaseOrderModel>("SyncPurchaseOrderFromSAP");

			var getPurchaseOrderForSupplier = builder.EntityType<PurchaseOrderModel>().Collection.Function("GetPurchaseOrderForSupplier");
			getPurchaseOrderForSupplier.Parameter<string>("site");
			getPurchaseOrderForSupplier.Parameter<string>("vendorCode");
			getPurchaseOrderForSupplier.ReturnsCollectionFromEntitySet<PurchaseOrderModel>("GetPurchaseOrderForSupplier");
 
			var getAllWorkCellBySite = builder.EntityType<WorkCellModel>().Collection.Function("GetAllWorkCellBySite");
			getAllWorkCellBySite.Parameter<string>("siteId");
			getAllWorkCellBySite.ReturnsCollectionFromEntitySet<WorkCellModel>("GetAllWorkCellBySite");


			builder.EntitySet<SAPPartInspectionPlanCommentModel>("SAPPartInspectionPlanComment").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getDccTasks = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetDccTasksData");
			getDccTasks.Parameter<int>("siteId");
			getDccTasks.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetDccTasksData");

			

			var getTasksDataByUserParams = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetTasksDataByUser");
			getTasksDataByUserParams.Parameter<int>("siteId");
			getTasksDataByUserParams.Parameter<int>("userId");
			getTasksDataByUserParams.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetTasksDataByUser");

			var getCompletelyApprovedIPPartNoForSupplier = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetCompletelyApprovedIPPartNoForSupplier");
			getCompletelyApprovedIPPartNoForSupplier.Parameter<int>("supplierId");
			getCompletelyApprovedIPPartNoForSupplier.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetCompletelyApprovedIPPartNoForSupplier");

			var getApprovedRejectDataByUser = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetApprovedRejectDataByUser");
			getApprovedRejectDataByUser.Parameter<int>("userId");
			getApprovedRejectDataByUser.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetApprovedRejectDataByUser");

			var getApprovedRejectDataBySite = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetApprovedRejectedDataBySite");
			getApprovedRejectDataBySite.Parameter<int>("siteId");
			getApprovedRejectDataBySite.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetApprovedRejectedDataBySite");

			var getSQEDCCApporvedDataByUser = builder.EntityType<SAPPartInspectionPlanModel>().Collection.Function("GetSQEDCCApprovedDataByUser");
			getSQEDCCApporvedDataByUser.Parameter<int>("userTypeId");
			getSQEDCCApporvedDataByUser.Parameter<int>("userId");
			getSQEDCCApporvedDataByUser.ReturnsCollectionFromEntitySet<SAPPartInspectionPlanModel>("GetSQEDCCApprovedDataByUser");

			builder.EntitySet<SupplierMeasurementSubmissionModel>("SupplierMeasurementSubmission").EntityType.Count().Filter().OrderBy().Expand().Select();
			
			builder.EntitySet<CertificateTypeModel>("CertificateType").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<DefectManagementModel>("DefectManagement").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<DefectSectionModel>("DefectSection").EntityType.Count().Filter().OrderBy().Expand().Select();
			
			builder.EntitySet<DefectTypeModel>("DefectType").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getDefectTypeNameBySection = builder.EntityType<DefectTypeModel>().Collection.Function("GetDefectTypeNameBySection");
			getDefectTypeNameBySection.Parameter<int>("defectSectionId");
			getDefectTypeNameBySection.ReturnsCollectionFromEntitySet<DefectTypeModel>("GetDefectTypeNameBySection");

			builder.EntitySet<SupplierFunctionAttributeModel>("SupplierFunctionAttribute").EntityType.Count().Filter().OrderBy().Expand().Select();
			
			builder.EntitySet<SupplierMicrosectionModel>("SupplierMicrosection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierDimensionMeasurementModel>("SupplierDimensionMeasurement").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierFunctionVariableModel>("SupplierFunctionVariable").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierSamplingPlanModel>("SupplierSamplingPlan").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierSapBasedParameterModel>("SupplierSapBasedParameter").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierVisualInspectionModel>("SupplierVisualInspection").EntityType.Count().Filter().OrderBy().Expand().Select();
			builder.EntitySet<SupplierVisualInspectionDefectTypeModel>("SupplierVisualInspectionDefectType").EntityType.Count().Filter().OrderBy().Expand().Select();
			var getSupplierVisualInspectionDefectTypeModelById = builder.EntityType<SupplierVisualInspectionDefectTypeModel>().Collection.Function("GetSupplierVisualInspectionDefectTypeModelById");
			getSupplierVisualInspectionDefectTypeModelById.Parameter<int>("id");
			getSupplierVisualInspectionDefectTypeModelById.Parameter<int>("parameterManagementId");
			getSupplierVisualInspectionDefectTypeModelById.ReturnsCollectionFromEntitySet<SupplierVisualInspectionDefectTypeModel>("GetSupplierVisualInspectionDefectTypeModelById");
			
			builder.EntitySet<SupplierTestReportAttachmentModel>("SupplierTestReportAttachment").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierDateCodeModel>("SupplierDateCode").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SAPSampleSizeCalcModel>("SAPSampleSize").EntityType.Count().Filter().OrderBy().Expand().Select();


			builder.EntitySet<SamplingPlanModel>("SamplingPlanSAPData").EntityType.Count().Filter().OrderBy().Expand().Select();

			

			var checkPartNumberExistsInSamplingModule = builder.EntityType<SamplingPlanModel>().Collection.Function("CheckPartNumberExistsInSamplingModule");			
			checkPartNumberExistsInSamplingModule.ReturnsCollectionFromEntitySet<SamplingPlanModel>("CheckPartNumberExistsInSamplingModule");

			var checkPartNumberExistsInPurchaseOrderModule = builder.EntityType<PurchaseOrderModel>().Collection.Function("CheckPartNumberExistsInPurchaseOrderModule");
			checkPartNumberExistsInPurchaseOrderModule.ReturnsCollectionFromEntitySet<PurchaseOrderModel>("CheckPartNumberExistsInPurchaseOrderModule");

			var checkPartNumberExistsInSampleSizeCalModule = builder.EntityType<SAPSampleSizeCalcModel>().Collection.Function("CheckPartNumberExistsInSampleSizeCalculationModule");
			checkPartNumberExistsInSampleSizeCalModule.ReturnsCollectionFromEntitySet<SAPSampleSizeCalcModel>("CheckPartNumberExistsInSampleSizeCalculationModule");

			builder.EntitySet<SupplierMPositionModel>("SupplierMPosition").EntityType.Count().Filter().OrderBy().Expand().Select();


			builder.EntitySet<DimensionDefaultModel>("DimensionDefault").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierLPositionModel>("SupplierLPosition").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getSampleSize = builder.EntityType<SAPSampleSizeCalcModel>().Collection.Function("GetSampleSize");
			getSampleSize.Parameter<int>("batchQuantity");
			getSampleSize.Parameter<string>("smplProc");
			getSampleSize.ReturnsCollectionFromEntitySet<SAPSampleSizeCalcModel>("GetSampleSize");

			builder.EntitySet<SupplierBowTwistModel>("SupplierBowTwists").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<InspectionToolsModel>("InspectionTools").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getActiveData = builder.EntityType<InspectionToolsModel>().Collection.Function("GetActiveData");
			getActiveData.ReturnsCollectionFromEntitySet<InspectionToolsModel>("GetActiveData");

			builder.EntitySet<RoleEnumModel>("RoleEnum").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getRoleForNonJabilUser = builder.EntityType<RoleModel>().Collection.Function("GetRoleForNonJabilUser");
			getRoleForNonJabilUser.ReturnsCollectionFromEntitySet<RoleModel>("GetRoleForNonJabilUser");

			var getRoleForJabilUser = builder.EntityType<RoleModel>().Collection.Function("GetRoleForJabilUser");
			getRoleForJabilUser.ReturnsCollectionFromEntitySet<RoleModel>("GetRoleForJabilUser");

			builder.EntitySet<ChartTypeModel>("ChartType").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierFailedQuantityModel>("SupplierFailedQuantity").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getFailedQuantityDataForSupplier = builder.EntityType<SupplierFailedQuantityModel>().Collection.Function("GetFailedQuantityDataForSupplier");
			getFailedQuantityDataForSupplier.Parameter<int>("SMSId");
			getFailedQuantityDataForSupplier.ReturnsCollectionFromEntitySet<SupplierFailedQuantityModel>("GetFailedQuantityDataForSupplier");


			builder.EntitySet<SupplierSpcChartModel>("SupplierSpcChart").EntityType.Count().Filter().OrderBy().Expand().Select();

			builder.EntitySet<SupplierSpcChartResultSummary>("SupplierSpcChartSummary").EntityType.Count().Filter().OrderBy().Expand().Select();

			var getSupplierSpcChartCalculation = builder.EntityType<SupplierSpcChartModel>().Collection.Function("GetSPCCPKChartStandardAverage");
			getSupplierSpcChartCalculation.Parameter<string>("iP");
			getSupplierSpcChartCalculation.Parameter<int>("countValue");
			getSupplierSpcChartCalculation.Parameter<int>("skipValue");
			getSupplierSpcChartCalculation.Parameter<int>("tabId");
			getSupplierSpcChartCalculation.Parameter<int>("smsId");
			getSupplierSpcChartCalculation.ReturnsCollectionFromEntitySet<SupplierSpcChartModel>("GetSPCCPKChartStandardAverage");

			var getSupplierSpcGenerateSummary = builder.EntityType<SupplierSpcChartResultSummary>().Collection.Function("GetSupplierSpcChartSummary");
			getSupplierSpcGenerateSummary.Parameter<string>("iP");
			getSupplierSpcGenerateSummary.Parameter<int>("smsId");

			getSupplierSpcGenerateSummary.ReturnsCollectionFromEntitySet<SupplierSpcChartResultSummary>("GetSupplierSpcChartSummary");

			return builder.GetEdmModel();


			
		}
	}
}
