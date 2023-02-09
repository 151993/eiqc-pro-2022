using Amazon.S3;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QSS.Common.Utilities.FileStorage;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Helper;
using QSS.eIQC.Handlers.Helper.UserEmailNotification;
using QSS.Infrastructure.Core.Services.FileService;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Implementations;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Interfaces;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System.Collections.Generic;
using System.Net.Http;
using QSS.eIQC.TM1Sync.Interface;
using QSS.eIQC.TM1Sync.Implementation;
using QSS.eIQC.Api.Services.Implementation;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Implementation;
using QSS.eIQC.DataAccess.Repositories.SAPDataSync;
using QSS.eIQC.SAPSync.Interface;
using QSS.eIQC.SAPSync.Implementation;

namespace QSS.eIQC.Api.Extensions.DependencyInjection
{
	/// <summary>
	/// register all dependencies
	/// </summary>
	public static class DependencyInjectionExtension
	{
		// public delegate IService ServiceResolver(string key);
		public enum ServiceStorageEnum
		{
			OnPremises,
			Aws
		}

		public delegate IFileService StorageServiceResolver(ServiceStorageEnum key);

		/// <summary>
		/// Configure all dependency injection
		/// </summary>
		/// <param name="services">Application services<see cref="IServiceCollection"/></param>
		/// <param name="configuration">Application configuration<see cref="IConfiguration"/></param>
		public static void DependencyInyectionConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddHttpClient("QssGatewayAPIService").ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
			{
				ClientCertificateOptions = ClientCertificateOption.Manual,
				ServerCertificateCustomValidationCallback =
				(httpRequestMessage, cert, cetChain, policyErrors) =>
				{
					return true;
				}
			});

			services.AddScoped<DbContext, QSSContext>();
			services.AddScoped<IQSSContext, QSSContext>();
			services.AddScoped<IQSSGatewayAPIClient, QSSGatewayAPIClient>();
			services.AddScoped<IEmailNotificationHelper, EmailNotificationHelper>();
			services.AddScoped<IUserEmailNotificationHelper, UserEmailNotificationHelper>();
			services.AddScoped<IRoleRepository, RoleRepository>();
			services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IDepartmentRepository, DepartmentRepository>();
			services.AddScoped<IRegionRepository, RegionRepository>();
			services.AddScoped<IUserRoleRepository, UserRoleRepository>();
			services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
			services.AddScoped<IDivisionRepository, DivisionRepository>();
			services.AddScoped<ILocationRepository, LocationRepository>();
			services.AddScoped<ICountryRepository, CountryRepository>();
			services.AddScoped<IWorkCellRepository, WorkCellRepository>();
			services.AddScoped<ISiteRepository, SiteRepository>();
			services.AddScoped<ISiteDivisionRepository, SiteDivisionRepository>();
			services.AddScoped<ISiteWorkCellRepository, SiteWorkCellRepository>();
			services.AddScoped<ISiteDepartmentRepository, SiteDepartmentRepository>();
			services.AddScoped<IManagerRepository, ManagerRepository>();
			services.AddScoped<ISiteUserRepository, SiteUserRepository>();
			services.AddScoped<IBuyerRepository, BuyerRepository>();
			services.AddScoped<ICompletedGRSRepository, CompletedGRSRepository>();
			services.AddScoped<ICustomerRepository, CustomerRepository>();
			services.AddScoped<IUserCustomerRepository, UserCustomerRepository>();
			services.AddScoped<IDefectTypeRepository, DefectTypeRepository>();
			services.AddScoped<ICTParameterRepository, CTParameterRepository>();			
			services.AddScoped<IUOMRepository, UOMRepository>();
			services.AddScoped<IGoodsReceiveUserRepository, GoodsReceiveUserRepository>();
			services.AddScoped<IGroupRepository, GroupRepository>();
			services.AddScoped<IInspectionToolsTypeRepository, InspectionToolsTypeRepository>();
			services.AddScoped<IInstrumentTypeRepository, InstrumentTypeRepository>();
			services.AddScoped<IGRSSAPResultRepository, GRSSAPResultRepository>();
			services.AddScoped<ILotInspectionQtyRepository, LotInspectionQtyRepository>();
			services.AddScoped<IParameterTypeRepository, ParameterTypeRepository>();
			services.AddScoped<IPartCAFRepository, PartCAFRepository>();
			services.AddScoped<IPCCodeRepository, PCCodeRepository>();
			services.AddScoped<IReceiveGoodsInfoRepository, ReceiveGoodsInfoRepository>();
			services.AddScoped<IReceiveGoodsInfoManualRepository, ReceiveGoodsInfoManualRepository>();
			services.AddScoped<IRosettaRepository, RosettaRepository>();
			services.AddScoped<IParameterCategoryRepository, ParameterCategoryRepository>();
			services.AddScoped<IDispositionTypeRepository, DispositionTypeRepository>();
			services.AddScoped<ISupplierFormCountParameterRepository, SupplierFormCountParameterRepository>();
			services.AddScoped<ISupplierTestReportRepository, SupplierTestReportRepository>();
			services.AddScoped<ISupplierFormSAPParameterRepository, SupplierFormSAPParameterRepository>();
			services.AddScoped<ISupplierFormBowTwistParameterRepository, SupplierFormBowTwistParameterRepository>();
			services.AddScoped<ISupplierFormSpecialParameterRepository, SupplierFormSpecialParameterRepository>();
			services.AddScoped<ISupplierFormResultOrientedParameterRepository, SupplierFormResultOrientedParameterRepository>();
			services.AddScoped<ISupplierFormRepository, SupplierFormRepository>();
			services.AddScoped<ISupplierFormVISRepository, SupplierFormVISRepository>();
			services.AddScoped<ISupplierFormPackagingRepository, SupplierFormPackagingRepository>();
			services.AddScoped<ISupplierFormPartDateCodeRepository, SupplierFormPartDateCodeRepository>();
			services.AddScoped<ISupplierFormBowTwistActualRepository, SupplierFormBowTwistActualRepository>();
			services.AddScoped<ISupplierFormFunParaRepository, SupplierFormFunParaRepository>();
			services.AddScoped<ISupplierFormFunParaActualRepository, SupplierFormFunParaActualRepository>();
			services.AddScoped<ISupplierFormLPositionRepository, SupplierFormLPositionRepository>();
			services.AddScoped<ISupplierFormLPositionActualRepository, SupplierFormLPositionActualRepository>();
			services.AddScoped<ISupplierFormMeasurementParameterRepository, SupplierFormMeasurementParameterRepository>();
			services.AddScoped<ISupplierFormMeasurementParameterActualRepository, SupplierFormMeasurementParameterActualRepository>();
			services.AddScoped<ISupplierFormMicroSectionActualRepository, SupplierFormMicroSectionActualRepository>();
			services.AddScoped<ISupplierFormMPositionRepository, SupplierFormMPositionRepository>();
			services.AddScoped<ISupplierFormMPositionActualRepository, SupplierFormMPositionActualRepository>();
			services.AddScoped<ISupplierFormMicroSectionRepository, SupplierFormMicroSectionRepository>();
			services.AddScoped<ISupplierAttachmentRepository, SupplierAttachmentRepository>();
			services.AddScoped<IInspectionRepository, InspectionRepository>();
			services.AddScoped<IInspectionToolsRepository, InspectionToolsRepository>();
			services.AddScoped<IInstrumentRepository, InstrumentRepository>();
			services.AddScoped<IGRSRepository, GRSRepository>();
			services.AddScoped<ISAPPartInspectionPlanRepository, SAPPartInspectionPlanRepository>();
			services.AddScoped<IPCCodeInspectionToolsTypeRepository, PCCodeInspectionToolsTypeRepository>();
			services.AddScoped<IGRSSupplierFormRepository, GRSSupplierFormRepository>();
			services.AddScoped<IPartRepository, PartRepository>();
			services.AddScoped<IPartInspectionBowTwistParameterRepository, PartInspectionBowTwistParameterRepository>();
			services.AddScoped<IPartCountParameterRepository, PartCountParameterRepository>();
			services.AddScoped<IPartDateCodeRepository, PartDateCodeRepository>();
			services.AddScoped<IPartFunParameterRepository, PartFunParameterRepository>();
			services.AddScoped<IPartLPositionToleranceRepository, PartLPositionToleranceRepository>();
			services.AddScoped<IPartMeasurementParameterRepository, PartMeasurementParameterRepository>();
			services.AddScoped<IPartMicrosectionRepository, PartMicrosectionRepository>();
			services.AddScoped<IPartMPositionToleranceRepository, PartMPositionToleranceRepository>();
			services.AddScoped<IPartResultOrientedParameterRepository, PartResultOrientedParameterRepository>();
			services.AddScoped<IPartTestReportParameterRepository, PartTestReportParameterRepository>();
			services.AddScoped<IFormRepository, FormRepository>();
			services.AddScoped<IFormBowTwistParameterRepository, FormBowTwistParameterRepository>();
			services.AddScoped<IFormCountParameterRepository, FormCountParameterRepository>();
			services.AddScoped<IFormFunParaRepository, FormFunParaRepository>();
			services.AddScoped<IFormFunParaActualRepository, FormFunParaActualRepository>();
			services.AddScoped<IFormLPositionRepository, FormLPositionRepository>();
			services.AddScoped<IFormLPositionActualRepository, FormLPositionActualRepository>();
			services.AddScoped<IFormMeasurementParameterRepository, FormMeasurementParameterRepository>();
			services.AddScoped<IFormMeasurementParameterActualRepository, FormMeasurementParameterActualRepository>();
			services.AddScoped<IFormBowTwistActualRepository, FormBowTwistActualRepository>();
			services.AddScoped<IFormMicroSectionRepository, FormMicroSectionRepository>();
			services.AddScoped<IFormMicroSectionActualRepository, FormMicroSectionActualRepository>();
			services.AddScoped<IFormMPositionRepository, FormMPositionRepository>();
			services.AddScoped<IFormMPositionActualRepository, FormMPositionActualRepository>();
			services.AddScoped<IFormPackagingRepository, FormPackagingRepository>();
			services.AddScoped<IFormPartDateCodeRepository, FormPartDateCodeRepository>();
			services.AddScoped<IFormPartSAPFailedQtyRepository, FormPartSAPFailedQtyRepository>();
			services.AddScoped<IFormResultOrientedParameterRepository, FormResultOrientedParameterRepository>();
			services.AddScoped<IFormSAPParameterRepository, FormSAPParameterRepository>();
			services.AddScoped<IFormSpecialParameterRepository, FormSpecialParameterRepository>();
			services.AddScoped<IFormStatusRepository, FormStatusRepository>();
			services.AddScoped<IFormTestReportRepository, FormTestReportRepository>();
			services.AddScoped<IFormVISRepository, FormVISRepository>();
			services.AddScoped<IFormTypeRepository, FormTypeRepository>();
			services.AddScoped<ITM1DataSyncDetailsRepository, TM1DataSyncDetailsRepository>();
			services.AddScoped<ISyncTM1DataHelper, SyncTM1DataHelper>();
			services.AddScoped<ISAPHanaClient, SAPHanaMoqClient>();
			services.AddScoped<ICommodityRepository, CommodityRepository>();
			services.AddScoped<IMaterialGroupRepository, MaterialGroupRepository>();
			services.AddScoped<ISAPDataSyncDetailsRepository, SAPDataSyncDetailsRepository>();
			services.AddScoped<ISyncSAPDataHelper, SyncSAPDataHelper>();
			services.AddScoped<IInspectionToolsTypePcCodeRepository, InspectionToolsTypePcCodeRepository>();
			services.AddScoped<ISupplierRepository, SupplierRepository>();

			services.AddScoped<SAPPartService>();
			services.AddScoped<IAdminCertificationRepository, AdminCertificationRepository>();
			services.AddScoped<IAdminCertificationAttachmentRepository, AdminCertificationAttachmentRepository>();
			services.AddScoped<IPartInspectionDrawingAttachmentRepository, PartInspectionDrawingAttachmentRepository>();
			services.AddScoped<IPartInspectionSpecAttachmentRepository, PartInspectionSpecAttachmentRepository>();

			services.AddScoped<IParameterManagementRepository, ParameterManagementRepository>();
			services.AddScoped<IParameterManagementCommodityRepository, ParameterManagementCommodityRepository>();
			services.AddScoped<ITestReportRepository, TestReportRepository>();
			services.AddScoped<ITestReportCommodityRepository, TestReportCommodityRepository>();
			services.AddScoped<IParameterTypeCodeRepository, ParameterTypeCodeRepository>();
			services.AddScoped<IParameterTypePcCodeRepository, ParameterTypePcCodeRepository>();
			services.AddScoped<IPartDateCodeRepository, PartDateCodeRepository>();
			services.AddScoped<IWorkCellUserRepository, WorkCellUserRepository>();
			services.AddScoped<IWorkCellJabilUserRepository, WorkCellJabilUserRepository>();
			services.AddScoped<IWorkCellDccUserRepository, WorkCellDccUserRepository>();
			services.AddScoped<ISAPPartInspectionPlanSupplierRepository, SAPPartInspectionPlanSupplierRepository>();
			services.AddScoped<ISAPPartInspectionPlanAdminCertificationRepository, SAPPartInspectionPlanAdminCertificationRepository>();
			services.AddScoped<IPartDimensionRepository, PartDimensionRepository>();
			services.AddScoped<IBowTwistFormulaRepository, BowTwistFormulaRepository>();
			services.AddScoped<IDCCConfigurationRepository, DCCConfigurationRepository>();

			services.AddScoped<IAttachmentRepository, AttachmentRepository>();
			services.AddScoped<IPartInspectionCertificationAttachmentRepository, PartInspectionCertificationAttachmentRepository>();
			services.AddScoped<IPartTestReportAttachmentRepository, PartTestReportAttachmentRepository>();
			services.AddScoped<IWorkCellSiteRepository, WorkCellSiteRepository>();
			services.AddScoped<ICommodityCategoryRepository, CommodityCategoryRepository>();

			services.AddScoped<IPartInspectionSpecificationRepository, PartInspectionSpecificationRepository>();
			services.AddScoped<IPartInspectionDrawingRepository, PartInspectionDrawingRepository>();
			services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
			services.AddScoped<ISupplierMeasurementSubmissionRepository, SupplierMeasurementSubmissionRepository>();
			services.AddScoped<ISAPPartInspectionPlanSamplingPlanRepository, SAPPartInspectionPlanSamplingPlanRepository>();
			services.AddScoped<ICertificateTypeRepository, CertificateTypeRepository>();
			services.AddScoped<ICertificateTypeParameterRepository, CertificateTypeParameterRepository>();
			services.AddScoped<IDefectManagementRepository, DefectManagementRepository>();
			services.AddScoped<IDefectTypeRepository, DefectTypeRepository>();
			services.AddScoped<ISupplierFunctionAttributeRepository, SupplierFunctionAttributeRepository>();
			services.AddScoped<ISupplierFunctionAttributeDefectTypeRepository, SupplierFunctionAttributeDefectTypeRepository>();
			services.AddScoped<ISupplierMicrosectionRepository, SupplierMicrosectionRepository>();
			services.AddScoped<ISupplierMicroSectionActualRepository, SupplierMicroSectionActualRepository>();
			services.AddScoped<ISupplierDimensionMeasurementRepository, SupplierDimensionMeasurementRepository>();
			services.AddScoped<ISupplierDimensionMeasurementActualRepository, SupplierDimensionMeasurementActualRepository>();
			services.AddScoped<ISupplierFunctionVariableRepository, SupplierFunctionVariableRepository>();
			services.AddScoped<ISupplierFunctionVariableActualRepository, SupplierFunctionVariableActualRepository>();
			services.AddScoped<ISupplierSamplingPlanRepository, SupplierSamplingPlanRepository>();
			services.AddScoped<ISupplierSapBasedParameterRepository, SupplierSapBasedParameterRepository>();
			services.AddScoped<ISupplierSapBasedParameterDefectTypeRepository, SupplierSapBasedParameterDefectTypeRepository>();
			services.AddScoped<ISupplierMPositionRepository, SupplierMPositionRepository>();

			services.AddScoped<ISupplierTestReportRepository, SupplierTestReportRepository>();
			services.AddScoped<ISupplierTestReportAttachmentRepository, SupplierTestReportAttachmentRepository>();
			services.AddScoped<ISupplierDateCodeRepository, SupplierDateCodeRepository>();
			services.AddScoped<ISupplierBowTwistRepository, SupplierBowTwistRepository>();
			services.AddScoped<ISupplierBowTwistActualRepository, SupplierBowTwistActualRepository>();

			services.AddScoped<ISupplierMPositionActualRepository, SupplierMPositionActualRepository>();
			services.AddScoped<ISupplierMPositionRepository, SupplierMPositionRepository>();

			services.AddScoped<ISupplierLPositionActualRepository, SupplierLPositionActualRepository>();
			services.AddScoped<ISupplierLPositionRepository, SupplierLPositionRepository>();
			services.AddScoped<ISupplierFunctionAttributeActualRepository, SupplierFunctionAttributeActualRepository>();


			services.AddScoped<ISupplierVisualInspectionRepository, SupplierVisualInspectionRepository>();
			services.AddScoped<ISupplierVisualInspectionDefectTypeRepository, SupplierVisualInspectionDefectTypeRepository>();
			services.AddScoped<ISMSCommentAttachmentRepository, SMSCommentAttachmentRepository>();
			
			//services.AddScoped<ITMOne, TmOne>();
			//services.AddScoped<IDapperService, DapperService>();
			//services.AddScoped<ISyncTmOneToEbaseline, SyncTmOneToEbaseline>();
			services.AddSingleton(configuration);
			services.AddSingleton<IFileStorageHelper, FileStorageHelper>(x => new FileStorageHelper(configuration.GetSection("FileStorageHelperConfiguration").Get<FileStorageHelperConfiguration>()));
		}

		/// <summary>
		/// enables AWS storage
		/// </summary>
		/// <param name="services">Application services<see cref="IServiceCollection"/></param>
		/// <param name="configuration"></param>
		public static void AwsStorageDependency(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IFileExtensionService, AwsFileService>();

			services.AddTransient<FileService>();
			services.AddTransient<AwsFileService>();
			services.AddTransient<StorageServiceResolver>(serviceProvider => key =>
			{
				switch (key)
				{
					case ServiceStorageEnum.OnPremises:
						return serviceProvider.GetService<FileService>();
					case ServiceStorageEnum.Aws:
						return serviceProvider.GetService<AwsFileService>();
					default:
						throw new KeyNotFoundException(); // or maybe return null, up to you
				}
			});

			services.AddAWSService<IAmazonS3>(configuration.GetAWSOptions());
			services.AddSingleton<IFilesRepository, FilesRepository>();
		}
	}
}
