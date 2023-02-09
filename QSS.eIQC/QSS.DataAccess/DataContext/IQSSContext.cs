using Microsoft.EntityFrameworkCore;
using QSS.Models;
using QSS.eIQC.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.DataAccess.DataContext
{
    public interface IQSSContext
    {
        DbSet<AuditLog> AuditLog { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Role> Role { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<Region> Region { get; set; }
        DbSet<RolePermission> RolePermission { get; set; }

        DbSet<UserRole> UserRole { get; set; }

        DbSet<EmailTemplate> EmailTemplate { get; set; }

        DbSet<Attachment> Attachment { get; set; }
        DbSet<Division> Division { get; set; }

        DbSet<Location> Location { get; set; }

        DbSet<Country> Country { get; set; }

        DbSet<WorkCell> WorkCell { get; set; }

        DbSet<Site> Site { get; set; }

        DbSet<TM1DataSyncDetails> TM1DataSyncDetails { get; set; }

        DbSet<Manager> Manager { get; set; }

        DbSet<SiteUser> SiteUser { get; set; }

        DbSet<Buyer> Buyer { get; set; }
        DbSet<CompletedGRS> CompletedGRS { get; set; }
        DbSet<Customer> Customer { get; set; }

        DbSet<UserCustomer> UserCustomer { get; set; }


        DbSet<CTParameter> CTParameter { get; set; }

        #region Auto Generated Forms DB Tables

        DbSet<SupplierForm> SupplierForm { get; set; }

        DbSet<SupplierFormVIS> SupplierFormVIS { get; set; }

        DbSet<UOM> UOM { get; set; }

        DbSet<GoodsReceiveUser> GoodsReceiveUser { get; set; }
        DbSet<Group> Group { get; set; }
        DbSet<InspectionToolsType> InspectionToolsType { get; set; }
        DbSet<InstrumentType> InstrumentType { get; set; }
        DbSet<GRSSAPResult> GRSSAPResult { get; set; }
        DbSet<LotInspectionQty> LotInspectionQty { get; set; }
        DbSet<ParameterType> ParameterType { get; set; }
        DbSet<PartCAF> PartCAF { get; set; }
        DbSet<PCCode> PCCode { get; set; }
        DbSet<ReceiveGoodsInfo> ReceiveGoodsInfo { get; set; }
        DbSet<ReceiveGoodsInfoManual> ReceiveGoodsInfoManual { get; set; }
        DbSet<Rosetta> Rosetta { get; set; }

        DbSet<DispositionType> DispositionType { get; set; }
        DbSet<ParameterCategory> ParameterCategory { get; set; }
        DbSet<SupplierFormCountParameter> SupplierFormCountParameter { get; set; }
        DbSet<SupplierTestReport> SupplierTestReport { get; set; }
        DbSet<SupplierFormSAPParameter> SupplierFormSAPParameter { get; set; }
        DbSet<SupplierFormBowTwistParameter> SupplierFormBowTwistParameter { get; set; }
        DbSet<SupplierFormSpecialParameter> SupplierFormSpecialParameter { get; set; }
        DbSet<SupplierFormResultOrientedParameter> SupplierFormResultOrientedParameter { get; set; }

        DbSet<SupplierFormPackaging> SupplierFormPackaging { get; set; }
        DbSet<SupplierFormPartDateCode> SupplierFormPartDateCode { get; set; }

        DbSet<SupplierFormBowTwistActual> SupplierFormBowTwistActual { get; set; }
        DbSet<SupplierFormFunPara> SupplierFormFunPara { get; set; }
        DbSet<SupplierFormFunParaActual> SupplierFormFunParaActual { get; set; }
        DbSet<SupplierFormLPosition> SupplierFormLPosition { get; set; }
        DbSet<SupplierFormLPositionActual> SupplierFormLPositionActual { get; set; }
        DbSet<SupplierFormMeasurementParameter> SupplierFormMeasurementParameter { get; set; }
        DbSet<SupplierFormMeasurementParameterActual> SupplierFormMeasurementParameterActual { get; set; }
        DbSet<SupplierFormMicroSection> SupplierFormMicroSection { get; set; }
        DbSet<SupplierFormMicroSectionActual> SupplierFormMicroSectionActual { get; set; }
        DbSet<SupplierFormMPosition> SupplierFormMPosition { get; set; }
        DbSet<SupplierFormMPositionActual> SupplierFormMPositionActual { get; set; }

        DbSet<SupplierAttachment> SupplierAttachment { get; set; }


        DbSet<Inspection> Inspection { get; set; }
        DbSet<InspectionTools> InspectionTools { get; set; }
        DbSet<Instrument> Instrument { get; set; }
        DbSet<GRS> GRS { get; set; }
        DbSet<SAPPartInspectionPlan> SAPPartInspectionPlan { get; set; }
        DbSet<PCCodeInspectionToolsType> PCCodeInspectionToolsType { get; set; }
        DbSet<GRSSupplierForm> GRSSupplierForm { get; set; }
        DbSet<Part> Part { get; set; }
        DbSet<PartInspectionBowTwistParameter> PartInspectionBowTwistParameter { get; set; }
        DbSet<PartCountParameter> PartCountParameter { get; set; }

        DbSet<PartDateCode> PartDateCode { get; set; }
        DbSet<PartFunParameter> PartFunParameter { get; set; }
        DbSet<PartLPositionTolerance> PartLPositionTolerance { get; set; }
        DbSet<PartMeasurementParameter> PartMeasurementParameter { get; set; }
        DbSet<PartMicrosection> PartMicrosection { get; set; }
        DbSet<PartMPositionTolerance> PartMPositionTolerance { get; set; }
        DbSet<PartResultOrientedParameter> PartResultOrientedParameter { get; set; }
        DbSet<PartTestReportParameter> PartTestReportParameter { get; set; }

        DbSet<Form> Form { get; set; }
        DbSet<FormBowTwistParameter> FormBowTwistParameter { get; set; }
        DbSet<FormCountParameter> FormCountParameter { get; set; }
        DbSet<FormFunPara> FormFunPara { get; set; }
        DbSet<FormFunParaActual> FormFunParaActual { get; set; }
        DbSet<FormLPosition> FormLPosition { get; set; }
        DbSet<FormLPositionActual> FormLPositionActual { get; set; }
        DbSet<FormMeasurementParameter> FormMeasurementParameter { get; set; }
        DbSet<FormMeasurementParameterActual> FormMeasurementParameterActual { get; set; }
        DbSet<FormBowTwistActual> FormBowTwistActual { get; set; }

        DbSet<FormMicroSection> FormMicroSection { get; set; }
        DbSet<FormMicroSectionActual> FormMicroSectionActual { get; set; }
        DbSet<FormMPosition> FormMPosition { get; set; }
        DbSet<FormMPositionActual> FormMPositionActual { get; set; }
        DbSet<FormPackaging> FormPackaging { get; set; }
        DbSet<FormPartDateCode> FormPartDateCode { get; set; }
        DbSet<FormPartSAPFailedQty> FormPartSAPFailedQty { get; set; }
        DbSet<FormResultOrientedParameter> FormResultOrientedParameter { get; set; }
        DbSet<FormSAPParameter> FormSAPParameter { get; set; }
        DbSet<FormSpecialParameter> FormSpecialParameter { get; set; }
        DbSet<FormStatus> FormStatus { get; set; }
        DbSet<FormTestReport> FormTestReport { get; set; }
        DbSet<FormVIS> FormVIS { get; set; }

        #endregion

        DbSet<Commodity> Commodity { get; set; }
        DbSet<FormType> FormType { get; set; }

        DbSet<AdminCertification> AdminCertification { get; set; }

        DbSet<AdminCertificationAttachment> AdminCertificationAttachment { get; set; }

        DbSet<SAPDataSyncDetails> SAPDataSyncDetails { get; set; }
        DbSet<MaterialGroup> MaterialGroup { get; set; }

        DbSet<PartInspectionDrawingAttachment> PartInspectionDrawingAttachment { get; set; }

        DbSet<PartInspectionSpecAttachment> PartInspectionSpecAttachment { get; set; }

        DbSet<PartInspectionCertificationAttachment> PartInspectionCertificationAttachment { get; set; }

        DbSet<ParameterManagement> ParameterManagement { get; set; }

        DbSet<ParameterManagementCommodity> ParameterManagementCommodity { get; set; }
        

        DbSet<ParameterManagementTypeModel> ParameterManagementType { get; set; }

        DbSet<DataTypeModel> DataType { get; set; }

        DbSet<ProductLifeCycleStageModel> ProductLifeCycleStage { get; set; }

        DbSet<ChartTypeModel> ChartType { get; set; }

        DbSet<TestReport> TestReport { get; set; }

        DbSet<ParameterTypeCode> ParameterTypeCode { get; set; }

        DbSet<ParameterTypePcCode> ParameterTypePcCode { get; set; }

        DbSet<PartDateCode> DateCode { get; set; }

        DbSet<WorkCellUser> WorkCellUser { get; set; }
        
        DbSet<WorkCellJabilUser> WorkCellJabilUser { get; set; }
        DbSet<WorkCellSite> WorkCellSite { get; set; }

        DbSet<TestReportCommodity> TestReportCommodity { get; set; }

        DbSet<SAPPartInspectionPlanAdminCertification> SAPPartInspectionPlanAdminCertification { get; set; }

        DbSet<SAPPartInspectionPlanSupplier> SAPPartInspectionPlanSupplier { get; set; }

        DbSet<PartDimension> PartDimension { get; set; }


        DbSet<BowTwistFormula> BowTwistFormula { get; set; }

        DbSet<WarPageModel> WarPage { get; set; }

        DbSet<DCCConfiguration> DCCConfiguration { get; set; }

        DbSet<PartTestReportAttachment> PartTestReportAttachment { get; set; }

        DbSet<CommodityCategory> CommodityCategory { get; set; }

        DbSet<CommodityPartNumberSite> CommodityPartNumberSite { get; set; }

        DbSet<Supplier> Supplier { get; set; }

        DbSet<PartInspectionSpecification> PartInspectionSpecification { get; set; }

        DbSet<PartInspectionDrawing> PartInspectionDrawing { get; set; }

        DbSet<SAPPartInspectionPlanComment> SAPPartInspectionPlanComment { get; set; }

        DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        DbSet<CertificateType> CertificateType { get; set; }
        DbSet<CertificateTypeParameter> CertificateTypeParameter { get; set; }

        DbSet<SupplierMeasurementSubmission> SupplierMeasurementSubmission { get; set; }

        DbSet<DefectManagement> DefectManagement { get; set; }

        DbSet<DefectSectionModel> DefectSection { get; set; }

        DbSet<DefectType> DefectType { get; set; }

        DbSet<SupplierMicrosection> SupplierMicrosection { get; set; }
        DbSet<SupplierDimensionMeasurement> SupplierDimensionMeasurement { get; set; }
        DbSet<SupplierFunctionVariable> SupplierFunctionVariable { get; set; }
        DbSet<SupplierFunctionVariableActual> SupplierFunctionVariableActual { get; set; }
        DbSet<SupplierSamplingPlan> SupplierSamplingPlan { get; set; }

        DbSet<SupplierDateCode> SupplierDateCode { get; set; }

        DbSet<SupplierMPosition> SupplierMPosition { get; set; }

        DbSet<DimensionDefault> DimensionDefault { get; set; }
        DbSet<SupplierVisualInspection> SupplierVisualInspection { get; set; }
        DbSet<SupplierVisualInspectionDefectType> SupplierVisualInspectionDefectType { get; set; }

        DbSet<SupplierLPosition> SupplierLPosition { get; set; }
        DbSet<SupplierDimensionMeasurementActual> SupplierDimensionMeasurementActual { get; set; }

        DbSet<SupplierMicroSectionActual> SupplierMicroSectionActual { get; set; }

        DbSet<SupplierBowTwist> SupplierBowTwist { get; set; }

        DbSet<SupplierBowTwistActual> SupplierBowTwistActual { get; set; }

        DbSet<SupplierMPositionActual> SupplierMPositionActual { get; set; }

        DbSet<SupplierLPositionActual> SupplierLPositionActual { get; set; }

        DbSet<SupplierFunctionAttributeActual> SupplierFunctionAttributeActual { get; set; }

        DbSet<SupplierFunctionAttribute> SupplierFunctionAttribute { get; set; }

        DbSet<SupplierSapBasedParameter> SupplierSapBasedParameter { get; set; }
        DbSet<RoleEnumModel> RoleEnum { get; set; }
        int SaveChanges();

        ChangeTracker ChangeTracker { get; }
    }
}
