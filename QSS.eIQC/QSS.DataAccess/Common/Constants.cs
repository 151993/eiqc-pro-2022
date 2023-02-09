namespace QSS.eIQC.DataAccess.Common
{
    internal static class Constants
    {
        internal static class AuditLog
        {
            internal static class Title
            {
                #region Common

                private const string AddEntity = "Add new {0} [{1}]";

                private const string EditEntity = "Edit {0} [{1}]";

                private const string DeleteEntity = "Delete {0} [{1}]";

                #endregion

                #region Role

                public static string AddRole(string name) => string.Format(AddEntity, Entity.Role, name);

                public static string EditRole(string name) => string.Format(EditEntity, Entity.Role, name);

                public static string DeleteRole(string name) => string.Format(DeleteEntity, Entity.Role, name);

                #endregion

                #region User

                public static string AddUser(string name) => string.Format(AddEntity, Entity.User, name);

                public static string EditUser(string name) => string.Format(EditEntity, Entity.User, name);

                public static string DeleteUser(string name) => string.Format(DeleteEntity, Entity.User, name);

                #endregion

                #region EmailTemplate

                public static string EditEmailTemplate(string name) => string.Format(EditEntity, Entity.EmailTemplate, name);

                #endregion

                #region Department

                public static string AddDepartment(string name) => string.Format(AddEntity, Entity.Department, name);

                public static string EditDepartment(string name) => string.Format(EditEntity, Entity.Department, name);

                public static string DeleteDepartment(string name) => string.Format(DeleteEntity, Entity.Department, name);

                #endregion

                #region WorkCell

                public static string AddWorkCell(string name) => string.Format(AddEntity, Entity.WorkCell, name);

                public static string EditWorkCell(string name) => string.Format(EditEntity, Entity.WorkCell, name);

                public static string DeleteWorkCell(string name) => string.Format(DeleteEntity, Entity.WorkCell, name);

                #endregion
               
                #region Region

                
                public static string AddRegion(string name) => string.Format(AddEntity, Entity.Region, name);

                
                public static string EditRegion(string name) => string.Format(EditEntity, Entity.Region, name);

               
                public static string DeleteRegion(string name) => string.Format(DeleteEntity, Entity.Region, name);

                #endregion	

                #region Division
                public static string AddDivision(string name) => string.Format(AddEntity, Entity.Division, name);

				public static string EditDivision(string name) => string.Format(EditEntity, Entity.Division, name);

 				public static string DeleteDivision(string name) => string.Format(DeleteEntity, Entity.Division, name);
				#endregion

                #region Location

                public static string AddLocation(string name) => string.Format(AddEntity, Entity.Location, name);

                public static string EditLocation(string name) => string.Format(EditEntity, Entity.Location, name);

                public static string DeleteLocation(string name) => string.Format(DeleteEntity, Entity.Location, name);

                #endregion

                #region Country

                public static string AddCountry(string name) => string.Format(AddEntity, Entity.Country, name);

                public static string EditCountry(string name) => string.Format(EditEntity, Entity.Country, name);

                public static string DeleteCountry(string name) => string.Format(DeleteEntity, Entity.Country, name);

                #endregion

                #region Site

                public static string AddSite(string name) => string.Format(AddEntity, Entity.Site, name);

                public static string EditSite(string name) => string.Format(EditEntity, Entity.Site, name);

                public static string DeleteSite(string name) => string.Format(DeleteEntity, Entity.Site, name);

                #endregion


                #region MaterialGroup

                public static string AddMaterialGroup(string name) => string.Format(AddEntity, Entity.Site, name);

                public static string EditMaterialGroup(string name) => string.Format(EditEntity, Entity.Site, name);

                public static string DeleteMaterialGroup(string name) => string.Format(DeleteEntity, Entity.Site, name);

                #endregion

                #region Manager

                public static string AddManager(string name) => string.Format(AddEntity, Entity.Manager, name);

                public static string EditManager(string name) => string.Format(EditEntity, Entity.Manager, name);

                public static string DeleteManager(string name) => string.Format(DeleteEntity, Entity.Manager, name);

                #endregion

                #region SiteUser

                public static string AddSiteUser(string name) => string.Format(AddEntity, Entity.SiteUser, name);

                public static string EditSiteUser(string name) => string.Format(EditEntity, Entity.SiteUser, name);

                public static string DeleteSiteUser(string name) => string.Format(DeleteEntity, Entity.SiteUser, name);

                #endregion

                #region Buyer

                public static string AddBuyer(string name) => string.Format(AddEntity, Entity.Buyer, name);

                public static string EditBuyer(string name) => string.Format(EditEntity, Entity.Buyer, name);

                public static string DeleteBuyer(string name) => string.Format(DeleteEntity, Entity.Buyer, name);

                #endregion 

                #region CompletedGRS

                public static string AddCompletedGRS(string partNo) => string.Format(AddEntity, Entity.CompletedGRS, partNo);

                public static string EditCompletedGRS(string partNo) => string.Format(EditEntity, Entity.CompletedGRS, partNo);

                public static string DeleteCompletedGRS(string partNo) => string.Format(DeleteEntity, Entity.CompletedGRS, partNo);

                #endregion

                #region Customer

                public static string AddCustomer(string name) => string.Format(AddEntity, Entity.Customer, name);

                public static string EditCustomer(string name) => string.Format(EditEntity, Entity.Customer, name);

                public static string DeleteCustomer(string name) => string.Format(DeleteEntity, Entity.Customer, name);

                #endregion

                #region DefectType

                public static string AddDefectType(string name) => string.Format(AddEntity, Entity.DefectType, name);

                public static string EditDefectType(string name) => string.Format(EditEntity, Entity.DefectType, name);

                public static string DeleteDefectType(string name) => string.Format(DeleteEntity, Entity.DefectType, name);

                #endregion

                #region CTParameter

                public static string AddCTParameter(string name) => string.Format(AddEntity, Entity.CTParameter, name);

                public static string EditCTParameter(string name) => string.Format(EditEntity, Entity.CTParameter, name);

                public static string DeleteCTParameter(string name) => string.Format(DeleteEntity, Entity.CTParameter, name);

                #endregion

                #region SupplierForm

                public static string AddSupplierForm(string name) => string.Format(AddEntity, Entity.SupplierForm, name);

                public static string EditSupplierForm(string name) => string.Format(EditEntity, Entity.SupplierForm, name);

                public static string DeleteSupplierForm(string name) => string.Format(DeleteEntity, Entity.SupplierForm, name);

                #endregion

                #region SupplierFormVIS

                public static string AddSupplierFormVIS(string name) => string.Format(AddEntity, Entity.SupplierFormVIS, name);

                public static string EditSupplierFormVIS(string name) => string.Format(EditEntity, Entity.SupplierFormVIS, name);

                public static string DeleteSupplierFormVIS(string name) => string.Format(DeleteEntity, Entity.SupplierFormVIS, name);

                #endregion

                #region UOM

                public static string AddUOM(string name) => string.Format(AddEntity, Entity.UOM, name);

                public static string EditUOM(string name) => string.Format(EditEntity, Entity.UOM, name);

                public static string DeleteUOM(string name) => string.Format(DeleteEntity, Entity.UOM, name);

                #endregion

                #region GoodsReceiveUser

                public static string AddGoodsReceiveUser(string name) => string.Format(AddEntity, Entity.GoodsReceiveUser, name);

                public static string EditGoodsReceiveUser(string name) => string.Format(EditEntity, Entity.GoodsReceiveUser, name);

                public static string DeleteGoodsReceiveUser(string name) => string.Format(DeleteEntity, Entity.GoodsReceiveUser, name);

                #endregion

                #region Group

                public static string AddGroup(string name) => string.Format(AddEntity, Entity.Group, name);

                public static string EditGroup(string name) => string.Format(EditEntity, Entity.Group, name);

                public static string DeleteGroup(string name) => string.Format(DeleteEntity, Entity.Group, name);

                #endregion

                #region InspectionToolsType

                public static string AddInspectionToolsType(string name) => string.Format(AddEntity, Entity.InspectionToolsType, name);

                public static string EditInspectionToolsType(string name) => string.Format(EditEntity, Entity.InspectionToolsType, name);

                public static string DeleteInspectionToolsType(string name) => string.Format(DeleteEntity, Entity.InspectionToolsType, name);

                #endregion

                #region InstrumentType

                public static string AddInstrumentType(string name) => string.Format(AddEntity, Entity.InstrumentType, name);

                public static string EditInstrumentType(string name) => string.Format(EditEntity, Entity.InstrumentType, name);

                public static string DeleteInstrumentType(string name) => string.Format(DeleteEntity, Entity.InstrumentType, name);

                #endregion

                #region GRSSAPResult

                public static string AddGRSSAPResult(string name) => string.Format(AddEntity, Entity.GRSSAPResult, name);

                public static string EditGRSSAPResult(string name) => string.Format(EditEntity, Entity.GRSSAPResult, name);

                public static string DeleteGRSSAPResult(string name) => string.Format(DeleteEntity, Entity.GRSSAPResult, name);

                #endregion

                #region LotInspectionQty

                public static string AddLotInspectionQty(string name) => string.Format(AddEntity, Entity.LotInspectionQty, name);

                public static string EditLotInspectionQty(string name) => string.Format(EditEntity, Entity.LotInspectionQty, name);

                public static string DeleteLotInspectionQty(string name) => string.Format(DeleteEntity, Entity.LotInspectionQty, name);

                #endregion

                #region ParameterType

                public static string AddParameterType(string name) => string.Format(AddEntity, Entity.ParameterType, name);

                public static string EditParameterType(string name) => string.Format(EditEntity, Entity.ParameterType, name);

                public static string DeleteParameterType(string name) => string.Format(DeleteEntity, Entity.ParameterType, name);

                #endregion

                #region PartCAF

                public static string AddPartCAF(string name) => string.Format(AddEntity, Entity.PartCAF, name);

                public static string EditPartCAF(string name) => string.Format(EditEntity, Entity.PartCAF, name);

                public static string DeletePartCAF(string name) => string.Format(DeleteEntity, Entity.PartCAF, name);

                #endregion

                #region PCCode

                public static string AddPCCode(string name) => string.Format(AddEntity, Entity.PCCode, name);

                public static string EditPCCode(string name) => string.Format(EditEntity, Entity.PCCode, name);

                public static string DeletePCCode(string name) => string.Format(DeleteEntity, Entity.PCCode, name);

                #endregion

                #region ReceiveGoodsInfo

                public static string AddReceiveGoodsInfo(string name) => string.Format(AddEntity, Entity.ReceiveGoodsInfo, name);

                public static string EditReceiveGoodsInfo(string name) => string.Format(EditEntity, Entity.ReceiveGoodsInfo, name);

                public static string DeleteReceiveGoodsInfo(string name) => string.Format(DeleteEntity, Entity.ReceiveGoodsInfo, name);

                #endregion

                #region ReceiveGoodsInfoManual

                public static string AddReceiveGoodsInfoManual(string name) => string.Format(AddEntity, Entity.ReceiveGoodsInfoManual, name);

                public static string EditReceiveGoodsInfoManual(string name) => string.Format(EditEntity, Entity.ReceiveGoodsInfoManual, name);

                public static string DeleteReceiveGoodsInfoManual(string name) => string.Format(DeleteEntity, Entity.ReceiveGoodsInfoManual, name);

                #endregion

                #region Rosetta

                public static string AddRosetta(string name) => string.Format(AddEntity, Entity.Rosetta, name);

                public static string EditRosetta(string name) => string.Format(EditEntity, Entity.Rosetta, name);

                public static string DeleteRosetta(string name) => string.Format(DeleteEntity, Entity.Rosetta, name);

                #endregion

                #region ParameterCategory

                public static string AddParameterCategory(string name) => string.Format(AddEntity, Entity.ParameterCategory, name);

                public static string EditParameterCategory(string name) => string.Format(EditEntity, Entity.ParameterCategory, name);

                public static string DeleteParameterCategory(string name) => string.Format(DeleteEntity, Entity.ParameterCategory, name);

                #endregion

                #region DispositionType

                public static string AddDispositionType(string name) => string.Format(AddEntity, Entity.DispositionType, name);

                public static string EditDispositionType(string name) => string.Format(EditEntity, Entity.DispositionType, name);

                public static string DeleteDispositionType(string name) => string.Format(DeleteEntity, Entity.DispositionType, name);

                #endregion

                #region SupplierFormCountParameter

                public static string AddSupplierFormCountParameter(string name) => string.Format(AddEntity, Entity.SupplierFormCountParameter, name);

                public static string EditSupplierFormCountParameter(string name) => string.Format(EditEntity, Entity.SupplierFormCountParameter, name);

                public static string DeleteSupplierFormCountParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormCountParameter, name);

                #endregion

                #region SupplierTestReport

                public static string AddSupplierTestReport(int id) => string.Format(AddEntity, Entity.SupplierTestReport, id);

                public static string EditSupplierTestReport(int id) => string.Format(EditEntity, Entity.SupplierTestReport, id);

                public static string DeleteSupplierTestReport(int id) => string.Format(DeleteEntity, Entity.SupplierTestReport, id);

                #endregion

                #region SupplierFormSAPParameter

                public static string AddSupplierFormSAPParameter(string name) => string.Format(AddEntity, Entity.SupplierFormSAPParameter, name);

                public static string EditSupplierFormSAPParameter(string name) => string.Format(EditEntity, Entity.SupplierFormSAPParameter, name);

                public static string DeleteSupplierFormSAPParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormSAPParameter, name);

                #endregion

                #region SupplierFormBowTwistParameter

                public static string AddSupplierFormBowTwistParameter(string name) => string.Format(AddEntity, Entity.SupplierFormBowTwistParameter, name);

                public static string EditSupplierFormBowTwistParameter(string name) => string.Format(EditEntity, Entity.SupplierFormBowTwistParameter, name);

                public static string DeleteSupplierFormBowTwistParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormBowTwistParameter, name);

                #endregion

                #region SupplierFormSpecialParameter

                public static string AddSupplierFormSpecialParameter(string name) => string.Format(AddEntity, Entity.SupplierFormSpecialParameter, name);

                public static string EditSupplierFormSpecialParameter(string name) => string.Format(EditEntity, Entity.SupplierFormSpecialParameter, name);

                public static string DeleteSupplierFormSpecialParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormSpecialParameter, name);

                #endregion

                #region SupplierFormResultOrientedParameter

                public static string AddSupplierFormResultOrientedParameter(string name) => string.Format(AddEntity, Entity.SupplierFormResultOrientedParameter, name);

                public static string EditSupplierFormResultOrientedParameter(string name) => string.Format(EditEntity, Entity.SupplierFormResultOrientedParameter, name);

                public static string DeleteSupplierFormResultOrientedParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormResultOrientedParameter, name);

                #endregion

                #region SupplierFormPackaging

                public static string AddSupplierFormPackaging(string name) => string.Format(AddEntity, Entity.SupplierFormPackaging, name);

                public static string EditSupplierFormPackaging(string name) => string.Format(EditEntity, Entity.SupplierFormPackaging, name);

                public static string DeleteSupplierFormPackaging(string name) => string.Format(DeleteEntity, Entity.SupplierFormPackaging, name);

                #endregion

                #region SupplierFormPartDateCode

                public static string AddSupplierFormPartDateCode(string name) => string.Format(AddEntity, Entity.SupplierFormPartDateCode, name);

                public static string EditSupplierFormPartDateCode(string name) => string.Format(EditEntity, Entity.SupplierFormPartDateCode, name);

                public static string DeleteSupplierFormPartDateCode(string name) => string.Format(DeleteEntity, Entity.SupplierFormPartDateCode, name);

                #endregion

                #region SupplierFormBowTwistActual

                public static string AddSupplierFormBowTwistActual(string name) => string.Format(AddEntity, Entity.SupplierFormBowTwistActual, name);

                public static string EditSupplierFormBowTwistActual(string name) => string.Format(EditEntity, Entity.SupplierFormBowTwistActual, name);

                public static string DeleteSupplierFormBowTwistActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormBowTwistActual, name);

                #endregion

                #region SupplierFormFunPara

                public static string AddSupplierFormFunPara(string name) => string.Format(AddEntity, Entity.SupplierFormFunPara, name);

                public static string EditSupplierFormFunPara(string name) => string.Format(EditEntity, Entity.SupplierFormFunPara, name);

                public static string DeleteSupplierFormFunPara(string name) => string.Format(DeleteEntity, Entity.SupplierFormFunPara, name);

                #endregion

                #region SupplierFormFunParaActual

                public static string AddSupplierFormFunParaActual(string name) => string.Format(AddEntity, Entity.SupplierFormFunParaActual, name);

                public static string EditSupplierFormFunParaActual(string name) => string.Format(EditEntity, Entity.SupplierFormFunParaActual, name);

                public static string DeleteSupplierFormFunParaActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormFunParaActual, name);

                #endregion

                #region SupplierFormLPosition

                public static string AddSupplierFormLPosition(string name) => string.Format(AddEntity, Entity.SupplierFormLPosition, name);

                public static string EditSupplierFormLPosition(string name) => string.Format(EditEntity, Entity.SupplierFormLPosition, name);

                public static string DeleteSupplierFormLPosition(string name) => string.Format(DeleteEntity, Entity.SupplierFormLPosition, name);

                #endregion

                #region SupplierFormLPositionActual

                public static string AddSupplierFormLPositionActual(string name) => string.Format(AddEntity, Entity.SupplierFormLPositionActual, name);

                public static string EditSupplierFormLPositionActual(string name) => string.Format(EditEntity, Entity.SupplierFormLPositionActual, name);

                public static string DeleteSupplierFormLPositionActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormLPositionActual, name);

                #endregion

                #region SupplierFormMeasurementParameter

                public static string AddSupplierFormMeasurementParameter(string name) => string.Format(AddEntity, Entity.SupplierFormMeasurementParameter, name);

                public static string EditSupplierFormMeasurementParameter(string name) => string.Format(EditEntity, Entity.SupplierFormMeasurementParameter, name);

                public static string DeleteSupplierFormMeasurementParameter(string name) => string.Format(DeleteEntity, Entity.SupplierFormMeasurementParameter, name);

                #endregion

                #region SupplierFormMeasurementParameterActual

                public static string AddSupplierFormMeasurementParameterActual(string name) => string.Format(AddEntity, Entity.SupplierFormMeasurementParameterActual, name);

                public static string EditSupplierFormMeasurementParameterActual(string name) => string.Format(EditEntity, Entity.SupplierFormMeasurementParameterActual, name);

                public static string DeleteSupplierFormMeasurementParameterActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormMeasurementParameterActual, name);

                #endregion

                #region SupplierFormMicroSection

                public static string AddSupplierFormMicroSection(string name) => string.Format(AddEntity, Entity.SupplierFormMicroSection, name);

                public static string EditSupplierFormMicroSection(string name) => string.Format(EditEntity, Entity.SupplierFormMicroSection, name);

                public static string DeleteSupplierFormMicroSection(string name) => string.Format(DeleteEntity, Entity.SupplierFormMicroSection, name);

                #endregion

                #region SupplierFormMicroSectionActual

                public static string AddSupplierFormMicroSectionActual(string name) => string.Format(AddEntity, Entity.SupplierFormMicroSectionActual, name);

                public static string EditSupplierFormMicroSectionActual(string name) => string.Format(EditEntity, Entity.SupplierFormMicroSectionActual, name);

                public static string DeleteSupplierFormMicroSectionActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormMicroSectionActual, name);

                #endregion

                #region SupplierFormMPosition

                public static string AddSupplierFormMPosition(string name) => string.Format(AddEntity, Entity.SupplierFormMPosition, name);

                public static string EditSupplierFormMPosition(string name) => string.Format(EditEntity, Entity.SupplierFormMPosition, name);

                public static string DeleteSupplierFormMPosition(string name) => string.Format(DeleteEntity, Entity.SupplierFormMPosition, name);

                #endregion

                #region SupplierFormMPositionActual

                public static string AddSupplierFormMPositionActual(string name) => string.Format(AddEntity, Entity.SupplierFormMPositionActual, name);

                public static string EditSupplierFormMPositionActual(string name) => string.Format(EditEntity, Entity.SupplierFormMPositionActual, name);

                public static string DeleteSupplierFormMPositionActual(string name) => string.Format(DeleteEntity, Entity.SupplierFormMPositionActual, name);

                #endregion

                #region SupplierAttachment

                public static string AddSupplierAttachment(string name) => string.Format(AddEntity, Entity.SupplierAttachment, name);

                public static string EditSupplierAttachment(string name) => string.Format(EditEntity, Entity.SupplierAttachment, name);

                public static string DeleteSupplierAttachment(string name) => string.Format(DeleteEntity, Entity.SupplierAttachment, name);

                #endregion

                #region Inspection

                public static string AddInspection(string name) => string.Format(AddEntity, Entity.Inspection, name);

                public static string EditInspection(string name) => string.Format(EditEntity, Entity.Inspection, name);

                public static string DeleteInspection(string name) => string.Format(DeleteEntity, Entity.Inspection, name);

                #endregion


                #region InspectionTools

                public static string AddInspectionTools(string name) => string.Format(AddEntity, Entity.InspectionTools, name);

                public static string EditInspectionTools(string name) => string.Format(EditEntity, Entity.InspectionTools, name);

                public static string DeleteInspectionTools(string name) => string.Format(DeleteEntity, Entity.InspectionTools, name);

                #endregion

                #region Instrument

                public static string AddInstrument(string name) => string.Format(AddEntity, Entity.Instrument, name);

                public static string EditInstrument(string name) => string.Format(EditEntity, Entity.Instrument, name);

                public static string DeleteInstrument(string name) => string.Format(DeleteEntity, Entity.Instrument, name);

                #endregion

                #region GRS

                public static string AddGRS(string name) => string.Format(AddEntity, Entity.GRS, name);

                public static string EditGRS(string name) => string.Format(EditEntity, Entity.GRS, name);

                public static string DeleteGRS(string name) => string.Format(DeleteEntity, Entity.GRS, name);

                #endregion

                #region SAPPartInspectionPlan

                public static string AddSAPPartInspectionPlan(string name) => string.Format(AddEntity, Entity.SAPPartInspectionPlan, name);

                public static string EditSAPPartInspectionPlan(string name) => string.Format(EditEntity, Entity.SAPPartInspectionPlan, name);

                public static string DeleteSAPPartInspectionPlan(string name) => string.Format(DeleteEntity, Entity.SAPPartInspectionPlan, name);

                #endregion

                #region PCCodeInspectionToolsType

                public static string AddPCCodeInspectionToolsType(string name) => string.Format(AddEntity, Entity.PCCodeInspectionToolsType, name);

                public static string EditPCCodeInspectionToolsType(string name) => string.Format(EditEntity, Entity.PCCodeInspectionToolsType, name);

                public static string DeletePCCodeInspectionToolsType(string name) => string.Format(DeleteEntity, Entity.PCCodeInspectionToolsType, name);

                #endregion

                #region GRSSupplierForm

                public static string AddGRSSupplierForm(string name) => string.Format(AddEntity, Entity.GRSSupplierForm, name);

                public static string EditGRSSupplierForm(string name) => string.Format(EditEntity, Entity.GRSSupplierForm, name);

                public static string DeleteGRSSupplierForm(string name) => string.Format(DeleteEntity, Entity.GRSSupplierForm, name);

                #endregion

                #region Part

                public static string AddPart(string name) => string.Format(AddEntity, Entity.Part, name);

                public static string EditPart(string name) => string.Format(EditEntity, Entity.Part, name);

                public static string DeletePart(string name) => string.Format(DeleteEntity, Entity.Part, name);

                #endregion

                #region PartBowTwistParameter

                public static string AddPartBowTwistParameter(string name) => string.Format(AddEntity, Entity.PartBowTwistParameter, name);

                public static string EditPartBowTwistParameter(string name) => string.Format(EditEntity, Entity.PartBowTwistParameter, name);

                public static string DeletePartBowTwistParameter(string name) => string.Format(DeleteEntity, Entity.PartBowTwistParameter, name);

                #endregion

                #region PartCountParameter

                public static string AddPartCountParameter(string name) => string.Format(AddEntity, Entity.PartCountParameter, name);

                public static string EditPartCountParameter(string name) => string.Format(EditEntity, Entity.PartCountParameter, name);

                public static string DeletePartCountParameter(string name) => string.Format(DeleteEntity, Entity.PartCountParameter, name);

                #endregion
                #region PartDateCode

                public static string AddPartDateCode(string name) => string.Format(AddEntity, Entity.PartDateCode, name);

                public static string EditPartDateCode(string name) => string.Format(EditEntity, Entity.PartDateCode, name);

                public static string DeletePartDateCode(string name) => string.Format(DeleteEntity, Entity.PartDateCode, name);

                #endregion

                #region PartFunParameter

                public static string AddPartFunParameter(string name) => string.Format(AddEntity, Entity.PartFunParameter, name);

                public static string EditPartFunParameter(string name) => string.Format(EditEntity, Entity.PartFunParameter, name);

                public static string DeletePartFunParameter(string name) => string.Format(DeleteEntity, Entity.PartFunParameter, name);

                #endregion

                #region PartLPositionTolerance

                public static string AddPartLPositionTolerance(string name) => string.Format(AddEntity, Entity.PartLPositionTolerance, name);

                public static string EditPartLPositionTolerance(string name) => string.Format(EditEntity, Entity.PartLPositionTolerance, name);

                public static string DeletePartLPositionTolerance(string name) => string.Format(DeleteEntity, Entity.PartLPositionTolerance, name);

                #endregion

                #region PartMeasurementParameter

                public static string AddPartMeasurementParameter(string name) => string.Format(AddEntity, Entity.PartMeasurementParameter, name);

                public static string EditPartMeasurementParameter(string name) => string.Format(EditEntity, Entity.PartMeasurementParameter, name);

                public static string DeletePartMeasurementParameter(string name) => string.Format(DeleteEntity, Entity.PartMeasurementParameter, name);

                #endregion

                #region PartMicrosection

                public static string AddPartMicrosection(string name) => string.Format(AddEntity, Entity.PartMicrosection, name);

                public static string EditPartMicrosection(string name) => string.Format(EditEntity, Entity.PartMicrosection, name);

                public static string DeletePartMicrosection(string name) => string.Format(DeleteEntity, Entity.PartMicrosection, name);

                #endregion

                #region PartMPositionTolerance

                public static string AddPartMPositionTolerance(string name) => string.Format(AddEntity, Entity.PartMPositionTolerance, name);

                public static string EditPartMPositionTolerance(string name) => string.Format(EditEntity, Entity.PartMPositionTolerance, name);

                public static string DeletePartMPositionTolerance(string name) => string.Format(DeleteEntity, Entity.PartMPositionTolerance, name);

                #endregion

                #region PartResultOrientedParameter

                public static string AddPartResultOrientedParameter(string name) => string.Format(AddEntity, Entity.PartResultOrientedParameter, name);

                public static string EditPartResultOrientedParameter(string name) => string.Format(EditEntity, Entity.PartResultOrientedParameter, name);

                public static string DeletePartResultOrientedParameter(string name) => string.Format(DeleteEntity, Entity.PartResultOrientedParameter, name);

                #endregion

                #region PartTestReportParameter

                public static string AddPartTestReportParameter(string name) => string.Format(AddEntity, Entity.PartTestReportParameter, name);

                public static string EditPartTestReportParameter(string name) => string.Format(EditEntity, Entity.PartTestReportParameter, name);

                public static string DeletePartTestReportParameter(string name) => string.Format(DeleteEntity, Entity.PartTestReportParameter, name);

                #endregion

                #region Form

                public static string AddForm(string name) => string.Format(AddEntity, Entity.Form, name);

                public static string EditForm(string name) => string.Format(EditEntity, Entity.Form, name);

                public static string DeleteForm(string name) => string.Format(DeleteEntity, Entity.Form, name);

                #endregion

                #region FormBowTwistParameter

                public static string AddFormBowTwistParameter(string name) => string.Format(AddEntity, Entity.FormBowTwistParameter, name);

                public static string EditFormBowTwistParameter(string name) => string.Format(EditEntity, Entity.FormBowTwistParameter, name);

                public static string DeleteFormBowTwistParameter(string name) => string.Format(DeleteEntity, Entity.FormBowTwistParameter, name);

                #endregion

                #region FormCountParameter

                public static string AddFormCountParameter(string name) => string.Format(AddEntity, Entity.FormCountParameter, name);

                public static string EditFormCountParameter(string name) => string.Format(EditEntity, Entity.FormCountParameter, name);

                public static string DeleteFormCountParameter(string name) => string.Format(DeleteEntity, Entity.FormCountParameter, name);

                #endregion

                #region FormFunPara

                public static string AddFormFunPara(string name) => string.Format(AddEntity, Entity.FormFunPara, name);

                public static string EditFormFunPara(string name) => string.Format(EditEntity, Entity.FormFunPara, name);

                public static string DeleteFormFunPara(string name) => string.Format(DeleteEntity, Entity.FormFunPara, name);

                #endregion

                #region FormFunParaActual

                public static string AddFormFunParaActual(string name) => string.Format(AddEntity, Entity.FormFunParaActual, name);

                public static string EditFormFunParaActual(string name) => string.Format(EditEntity, Entity.FormFunParaActual, name);

                public static string DeleteFormFunParaActual(string name) => string.Format(DeleteEntity, Entity.FormFunParaActual, name);

                #endregion

                #region FormLPosition

                public static string AddFormLPosition(string name) => string.Format(AddEntity, Entity.FormLPosition, name);

                public static string EditFormLPosition(string name) => string.Format(EditEntity, Entity.FormLPosition, name);

                public static string DeleteFormLPosition(string name) => string.Format(DeleteEntity, Entity.FormLPosition, name);

                #endregion

                #region FormLPositionActual

                public static string AddFormLPositionActual(string name) => string.Format(AddEntity, Entity.FormLPositionActual, name);

                public static string EditFormLPositionActual(string name) => string.Format(EditEntity, Entity.FormLPositionActual, name);

                public static string DeleteFormLPositionActual(string name) => string.Format(DeleteEntity, Entity.FormLPositionActual, name);

                #endregion

                #region FormMeasurementParameter

                public static string AddFormMeasurementParameter(string name) => string.Format(AddEntity, Entity.FormMeasurementParameter, name);

                public static string EditFormMeasurementParameter(string name) => string.Format(EditEntity, Entity.FormMeasurementParameter, name);

                public static string DeleteFormMeasurementParameter(string name) => string.Format(DeleteEntity, Entity.FormMeasurementParameter, name);

                #endregion

                #region FormMeasurementParameterActual

                public static string AddFormMeasurementParameterActual(string name) => string.Format(AddEntity, Entity.FormMeasurementParameterActual, name);

                public static string EditFormMeasurementParameterActual(string name) => string.Format(EditEntity, Entity.FormMeasurementParameterActual, name);

                public static string DeleteFormMeasurementParameterActual(string name) => string.Format(DeleteEntity, Entity.FormMeasurementParameterActual, name);

                #endregion

                #region FormBowTwistActual

                public static string AddFormBowTwistActual(string name) => string.Format(AddEntity, Entity.FormBowTwistActual, name);

                public static string EditFormBowTwistActual(string name) => string.Format(EditEntity, Entity.FormBowTwistActual, name);

                public static string DeleteFormBowTwistActual(string name) => string.Format(DeleteEntity, Entity.FormBowTwistActual, name);

                #endregion

                #region FormMicroSection

                public static string AddFormMicroSection(string name) => string.Format(AddEntity, Entity.FormMicroSection, name);

                public static string EditFormMicroSection(string name) => string.Format(EditEntity, Entity.FormMicroSection, name);

                public static string DeleteFormMicroSection(string name) => string.Format(DeleteEntity, Entity.FormMicroSection, name);

                #endregion

                #region FormMicroSectionActual

                public static string AddFormMicroSectionActual(string name) => string.Format(AddEntity, Entity.FormMicroSectionActual, name);

                public static string EditFormMicroSectionActual(string name) => string.Format(EditEntity, Entity.FormMicroSectionActual, name);

                public static string DeleteFormMicroSectionActual(string name) => string.Format(DeleteEntity, Entity.FormMicroSectionActual, name);

                #endregion

                #region FormMPosition

                public static string AddFormMPosition(string name) => string.Format(AddEntity, Entity.FormMPosition, name);

                public static string EditFormMPosition(string name) => string.Format(EditEntity, Entity.FormMPosition, name);

                public static string DeleteFormMPosition(string name) => string.Format(DeleteEntity, Entity.FormMPosition, name);

                #endregion

                #region FormMPositionActual

                public static string AddFormMPositionActual(string name) => string.Format(AddEntity, Entity.FormMPositionActual, name);

                public static string EditFormMPositionActual(string name) => string.Format(EditEntity, Entity.FormMPositionActual, name);

                public static string DeleteFormMPositionActual(string name) => string.Format(DeleteEntity, Entity.FormMPositionActual, name);

                #endregion

                #region FormPackaging

                public static string AddFormPackaging(string name) => string.Format(AddEntity, Entity.FormPackaging, name);

                public static string EditFormPackaging(string name) => string.Format(EditEntity, Entity.FormPackaging, name);

                public static string DeleteFormPackaging(string name) => string.Format(DeleteEntity, Entity.FormPackaging, name);

                #endregion

                #region FormPartDateCode

                public static string AddFormPartDateCode(string name) => string.Format(AddEntity, Entity.FormPartDateCode, name);

                public static string EditFormPartDateCode(string name) => string.Format(EditEntity, Entity.FormPartDateCode, name);

                public static string DeleteFormPartDateCode(string name) => string.Format(DeleteEntity, Entity.FormPartDateCode, name);

                #endregion

                #region FormPartSAPFailedQty

                public static string AddFormPartSAPFailedQty(string name) => string.Format(AddEntity, Entity.FormPartSAPFailedQty, name);

                public static string EditFormPartSAPFailedQty(string name) => string.Format(EditEntity, Entity.FormPartSAPFailedQty, name);

                public static string DeleteFormPartSAPFailedQty(string name) => string.Format(DeleteEntity, Entity.FormPartSAPFailedQty, name);

                #endregion

                #region FormResultOrientedParameter

                public static string AddFormResultOrientedParameter(string name) => string.Format(AddEntity, Entity.FormResultOrientedParameter, name);

                public static string EditFormResultOrientedParameter(string name) => string.Format(EditEntity, Entity.FormResultOrientedParameter, name);

                public static string DeleteFormResultOrientedParameter(string name) => string.Format(DeleteEntity, Entity.FormResultOrientedParameter, name);

                #endregion

                #region FormSAPParameter

                public static string AddFormSAPParameter(string name) => string.Format(AddEntity, Entity.FormSAPParameter, name);

                public static string EditFormSAPParameter(string name) => string.Format(EditEntity, Entity.FormSAPParameter, name);

                public static string DeleteFormSAPParameter(string name) => string.Format(DeleteEntity, Entity.FormSAPParameter, name);

                #endregion

                #region FormSpecialParameter

                public static string AddFormSpecialParameter(string name) => string.Format(AddEntity, Entity.FormSpecialParameter, name);

                public static string EditFormSpecialParameter(string name) => string.Format(EditEntity, Entity.FormSpecialParameter, name);

                public static string DeleteFormSpecialParameter(string name) => string.Format(DeleteEntity, Entity.FormSpecialParameter, name);

                #endregion

                #region FormStatus

                public static string AddFormStatus(string name) => string.Format(AddEntity, Entity.FormStatus, name);

                public static string EditFormStatus(string name) => string.Format(EditEntity, Entity.FormStatus, name);

                public static string DeleteFormStatus(string name) => string.Format(DeleteEntity, Entity.FormStatus, name);

                #endregion

                #region FormTestReport

                public static string AddFormTestReport(string name) => string.Format(AddEntity, Entity.FormTestReport, name);

                public static string EditFormTestReport(string name) => string.Format(EditEntity, Entity.FormTestReport, name);

                public static string DeleteFormTestReport(string name) => string.Format(DeleteEntity, Entity.FormTestReport, name);

                #endregion

                #region FormVIS

                public static string AddFormVIS(string name) => string.Format(AddEntity, Entity.FormVIS, name);

                public static string EditFormVIS(string name) => string.Format(EditEntity, Entity.FormVIS, name);

                public static string DeleteFormVIS(string name) => string.Format(DeleteEntity, Entity.FormVIS, name);

                #endregion

                #region FormType

                public static string AddFormType(string name) => string.Format(AddEntity, Entity.FormType, name);

                public static string EditFormType(string name) => string.Format(EditEntity, Entity.FormType, name);

                public static string DeleteFormType(string name) => string.Format(DeleteEntity, Entity.FormType, name);

                #endregion

                #region Commodity

                public static string AddCommodity(string id) => string.Format(AddEntity, Entity.Commodity, id);

                public static string EditCommodity(string id) => string.Format(EditEntity, Entity.Commodity, id);

                public static string DeleteCommodity(string id) => string.Format(DeleteEntity, Entity.Commodity, id);

                #endregion

                #region Supplier

                public static string AddSupplier(string id) => string.Format(AddEntity, Entity.Supplier, id);

                public static string EditSupplier(string id) => string.Format(EditEntity, Entity.Supplier, id);

                public static string DeleteSupplier(string id) => string.Format(DeleteEntity, Entity.Supplier, id);

                #endregion

                #region Attachment

                public static string AddAttachment(string name) => string.Format(AddEntity, Entity.Attachment, name);

                public static string EditAttachment(string name) => string.Format(EditEntity, Entity.Attachment, name);

                public static string DeleteAttachment(string name) => string.Format(DeleteEntity, Entity.Attachment, name);

                #endregion

                #region AdminCertification

                public static string AddAdminCertification(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditAdminCertification(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeleteAdminCertification(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);

                #endregion

                #region ParameterManagement

                public static string AddParameterManagement(string name) => string.Format(AddEntity, Entity.ParameterManagement, name);

                public static string EditParameterManagement(string name) => string.Format(EditEntity, Entity.ParameterManagement, name);

                public static string DeleteParameterManagement(string name) => string.Format(DeleteEntity, Entity.ParameterManagement, name);

                #endregion


                #region TestReport

                public static string AddTestReport(string name) => string.Format(AddEntity, Entity.TestReport, name);

                public static string EditTestReport(string name) => string.Format(EditEntity, Entity.TestReport, name);

                public static string DeleteTestReport(string name) => string.Format(DeleteEntity, Entity.TestReport, name);

                #endregion

                #region ParameterTypeCode

                public static string AddParameterTypeCode(string name) => string.Format(AddEntity, Entity.ParameterTypeCode, name);

                public static string EditParameterTypeCode(string name) => string.Format(EditEntity, Entity.ParameterTypeCode, name);

                public static string DeleteParameterTypeCode(string name) => string.Format(DeleteEntity, Entity.ParameterTypeCode, name);

                #endregion

                #region DateCode

                public static string AddDateCode(string name) => string.Format(AddEntity, Entity.DateCode, name);

                public static string EditDateCode(string name) => string.Format(EditEntity, Entity.DateCode, name);

                public static string DeleteDateCode(string name) => string.Format(DeleteEntity, Entity.DateCode, name);

                #endregion

                #region WorkCellUser

                public static string AddWorkCellUser(string name) => string.Format(AddEntity, Entity.WorkCellUser, name);

                public static string EditWorkCellUser(string name) => string.Format(EditEntity, Entity.WorkCellUser, name);

                public static string DeleteWorkCellUser(string name) => string.Format(DeleteEntity, Entity.WorkCellUser, name);

                #endregion


                #region PartDimension

                public static string AddPartDimension(string name) => string.Format(AddEntity, Entity.PartDimension, name);

                public static string EditPartDimension(string name) => string.Format(EditEntity, Entity.PartDimension, name);

                public static string DeletePartDimension(string name) => string.Format(DeleteEntity, Entity.PartDimension, name);

                #endregion


                #region BowTwistFormula

                public static string AddBowTwistFormula(string name) => string.Format(AddEntity, Entity.BowTwistFormula, name);

                public static string EditBowTwistFormula(string name) => string.Format(EditEntity, Entity.BowTwistFormula, name);

                public static string DeleteBowTwistFormula(string name) => string.Format(DeleteEntity, Entity.BowTwistFormula, name);

                #endregion

                #region DCCConfiguration

                public static string AddDCCConfiguration(string name) => string.Format(AddEntity, Entity.DCCConfiguration, name);

                public static string EditDCCConfiguration(string name) => string.Format(EditEntity, Entity.DCCConfiguration, name);

                public static string DeleteDCCConfiguration(string name) => string.Format(DeleteEntity, Entity.DCCConfiguration, name);

                #endregion

                #region Part Inspection Certification Attachment

                public static string AddPartInspectionCertificationAttachment(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditPartInspectionCertificationAttachment(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeletePartInspectionCertificationAttachment(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);

                #endregion

                #region Part Inspection Certification Attachment

                public static string AddCommodityCategory(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditCommodityCategory(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeleteCommodityCategory(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);

                #endregion

                #region Part Inspection Specification
                public static string AddPartInspectionSpecification(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditPartInspectionSpecification(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeletePartInspectionSpecification(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);
                #endregion

                #region Part Inspection Drawing
                public static string AddPartInspectionDrawing(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditPartInspectionDrawing(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeletePartInspectionDrawing(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);
                #endregion

                #region Purchase Order
                public static string AddPurchaseOrder(string name) => string.Format(AddEntity, Entity.PurchaseOrder, name);

                public static string EditPurchaseOrder(string name) => string.Format(EditEntity, Entity.PurchaseOrder, name);

                public static string DeletePurchaseOrder(string name) => string.Format(DeleteEntity, Entity.PurchaseOrder, name);
                #endregion

                #region Part Inspection Comments
                public static string AddSAPPartInspectionPlanComment(string name) => string.Format(AddEntity, Entity.AdminCertification, name);

                public static string EditSAPPartInspectionPlanComment(string name) => string.Format(EditEntity, Entity.AdminCertification, name);

                public static string DeleteSAPPartInspectionPlanComment(string name) => string.Format(DeleteEntity, Entity.AdminCertification, name);
                #endregion

                #region CertificateType

                public static string AddCertificateType(string name) => string.Format(AddEntity, Entity.CertificateType, name);

                public static string EditCertificateType(string name) => string.Format(EditEntity, Entity.CertificateType, name);

                public static string DeleteCertificateType(string name) => string.Format(DeleteEntity, Entity.CertificateType, name);

                #endregion

                #region Supplier Measurement Submission
                public static string AddSupplierMeasurementSubmission(string name) => string.Format(AddEntity, Entity.SupplierMeasurementSubmission, name);

                public static string EditSupplierMeasurementSubmission(string name) => string.Format(EditEntity, Entity.SupplierMeasurementSubmission, name);

                public static string DeleteSupplierMeasurementSubmission(string name) => string.Format(DeleteEntity, Entity.SupplierMeasurementSubmission, name);
                #endregion

                #region Defect Management
                public static string AddDefectManagement(int id) => string.Format(AddEntity, Entity.DefectManagement, id);

                public static string EditDefectManagement(int id) => string.Format(EditEntity, Entity.DefectManagement, id);

                public static string DeleteDefectManagement(int id) => string.Format(DeleteEntity, Entity.DefectManagement, id);
                #endregion


                #region Supplier Sampling Plan
                public static string AddSupplierSamplingPlan(int id) => string.Format(AddEntity, Entity.DefectManagement, id);

                public static string EditSupplierSamplingPlan(int id) => string.Format(EditEntity, Entity.DefectManagement, id);

                public static string DeleteSupplierSamplingPlan(int id) => string.Format(DeleteEntity, Entity.DefectManagement, id);
                #endregion



                #region SMSCommentAttachment

                public static string AddSMSCommentAttachment(string name) => string.Format(AddEntity, Entity.SMSCommentAttachment, name);

                public static string EditSMSCommentAttachment(string name) => string.Format(EditEntity, Entity.SMSCommentAttachment, name);

                public static string DeleteSMSCommentAttachment(string name) => string.Format(DeleteEntity, Entity.SMSCommentAttachment, name);

                #endregion


            }
        }

        internal static class Entity
        {
            public const string Role = "Role";
            public const string User = "User";
            public const string EmailTemplate = "EmailTemplate";
            public const string Department = "Department";
            public const string WorkCell = "WorkCell";       
            public const string Region = "Region";
            public const string Division = "Division";
            public const string Location = "Location";
            public const string Country = "Country";
            public const string Site = "Site";
            public const string Manager = "Manager";
            public const string SiteUser = "SiteUser";
            public const string Buyer = "Buyer"; 
            public const string CompletedGRS = "CompletedGRS";
            public const string Customer = "Customer";
            public const string DefectType = "DefectType";
            public const string CTParameter = "CTParameter";
            public const string SupplierFormVIS = "SupplierFormVIS";
            public const string SupplierForm = "SupplierForm";
            public const string UOM = "UOM";
            public const string GoodsReceiveUser = "GoodsReceiveUser";
            public const string Group = "Group";
            public const string InspectionToolsType = "InspectionToolsType";
            public const string InstrumentType = "InstrumentType";
            public const string GRSSAPResult = "GRSSAPResult";
            public const string LotInspectionQty = "LotInspectionQty";
            public const string ParameterType = "ParameterType";
            public const string PartCAF = "PartCAF";
            public const string PCCode = "PCCode";
            public const string ReceiveGoodsInfo = "ReceiveGoodsInfo";
            public const string ReceiveGoodsInfoManual = "ReceiveGoodsInfoManual";
            public const string Rosetta = "Rosetta";
            public const string ParameterCategory = "ParameterCategory";
            public const string DispositionType = "DispositionType";
            public const string SupplierFormCountParameter = "SupplierFormCountParameter";
            public const string SupplierTestReport = "SupplierTestReport";
            public const string SupplierFormSAPParameter = "SupplierFormSAPParameter";
            public const string SupplierFormBowTwistParameter = "SupplierFormBowTwistParameter";
            public const string SupplierFormSpecialParameter = "SupplierFormSpecialParameter";
            public const string SupplierFormResultOrientedParameter = "SupplierFormResultOrientedParameter";
            public const string SupplierFormPackaging = "SupplierFormPackaging";
            public const string SupplierFormPartDateCode = "SupplierFormPartDateCode";
            public const string SupplierFormBowTwistActual = "SupplierFormBowTwistActual";
            public const string SupplierFormFunPara = "SupplierFormFunPara";
            public const string SupplierFormFunParaActual = "SupplierFormFunParaActual";
            public const string SupplierFormLPosition = "SupplierFormLPosition";
            public const string SupplierFormLPositionActual = "SupplierFormLPositionActual";
            public const string SupplierFormMeasurementParameter = "SupplierFormMeasurementParameter";
            public const string SupplierFormMeasurementParameterActual = "SupplierFormMeasurementParameterActual";
            public const string SupplierFormMicroSection = "SupplierFormMicroSection";
            public const string SupplierFormMicroSectionActual = "SupplierFormMicroSectionActual";
            public const string SupplierFormMPosition = "SupplierFormMPosition";
            public const string SupplierFormMPositionActual = "SupplierFormMPositionActual";
            public const string SupplierAttachment = "SupplierAttachment";
            public const string Inspection = "Inspection";
            public const string InspectionTools = "InspectionTools";
            public const string Instrument = "Instrument";
            public const string GRS = "GRS";
            public const string SAPPartInspectionPlan = "SAPPartInspectionPlan";
            public const string PCCodeInspectionToolsType = "PCCodeInspectionToolsType";
            public const string GRSSupplierForm = "GRSSupplierForm";
            public const string Part = "Part";
            public const string PartBowTwistParameter = "PartBowTwistParameter";
            public const string PartCountParameter = "PartCountParameter";
            public const string PartDateCode = "PartDateCode";
            public const string PartFunParameter = "PartFunParameter";
            public const string PartLPositionTolerance = "PartLPositionTolerance";
            public const string PartMeasurementParameter = "PartMeasurementParameter";
            public const string PartMicrosection = "PartMicrosection";
            public const string PartMPositionTolerance = "PartMPositionTolerance";
            public const string PartResultOrientedParameter = "PartResultOrientedParameter";
            public const string PartTestReportParameter = "PartTestReportParameter";
            public const string Form = "Form";
            public const string FormBowTwistParameter = "FormBowTwistParameter";
            public const string FormCountParameter = "FormCountParameter";
            public const string FormFunPara = "FormFunPara";
            public const string FormFunParaActual = "FormFunParaActual";
            public const string FormLPosition = "FormLPosition";
            public const string FormLPositionActual = "FormLPositionActual";
            public const string FormMeasurementParameter = "FormMeasurementParameter";
            public const string FormMeasurementParameterActual = "FormMeasurementParameterActual";
            public const string FormBowTwistActual = "FormBowTwistActual";
            public const string FormMicroSection = "FormMicroSection";
            public const string FormMicroSectionActual = "FormMicroSectionActual";
            public const string FormMPosition = "FormMPosition";
            public const string FormMPositionActual = "FormMPositionActual";
            public const string FormPackaging = "FormPackaging";
            public const string FormPartDateCode = "FormPartDateCode";
            public const string FormPartSAPFailedQty = "FormPartSAPFailedQty";
            public const string FormResultOrientedParameter = "FormResultOrientedParameter";
            public const string FormSAPParameter = "FormSAPParameter";
            public const string FormSpecialParameter = "FormSpecialParameter";
            public const string FormStatus = "FormStatus";
            public const string FormTestReport = "FormTestReport";
            public const string FormVIS = "FormVIS";
            public const string FormType = "FormType";
            public const string AdminCertification = "AdminCertification";
            public const string SMSCommentAttachment = "SMSCommentAttachment";            
            public const string Attachment = "Attachment";
            public const string Commodity = "Commodity";
            public const string ParameterManagement = "ParameterManagement";
            public const string TestReport = "TestReport";
            public const string ParameterTypeCode = "ParameterTypeCode";
            public const string DateCode = "DateCode";
            public const string WorkCellUser = "WorkCellUser";
            public const string WorkCellSite = "WorkCellSite";
            public const string PartDimension = "PartDimension";
            public const string BowTwistFormula = "BowTwistFormula";
            public const string DCCConfiguration = "DCCConfiguration";
            public const string PartInspectionCertificationAttachment = "PartInspectionCertificationAttachment";
            public const string CommodityCategory = "CommodityCategory";
            public const string Supplier = "Supplier";
            public const string PurchaseOrder = "PurchaseOrder";
            public const string CertificateType = "CertificateType";
            public const string SupplierMeasurementSubmission = "SupplierMeasurementSubmission";
            public const string DefectManagement = "DefectManagement";
        }
        internal static class IdentityStartValue
        {
            public const int Role = 2;
            public const int RolePermission = 47;
            public const int User = 8;
            public const int UserRole = 8;
            public const int Department = 2;
            public const int Manager = 4;
        }
        internal static class ErrorMessage
        {

            public static string RecordDoesNotExists<T>(T id) => $"Record with id {id} does not exists.";

            public static string AuditLogTypeNotSet = "AuditLogType not set. If you want to capture audit log then pass it through constructor.";

            public static string UserRoleDoesNotExists(int id) => $"UserRole with User Id {id} does not exists.";

            public static string RolePermissionsDoesNotExists(int id) => $"RolePermissions with Role Id {id} does not exists.";

            public static string RecordNotUnique(string propertyName) => $"{propertyName} has been taken. Please specify a different {propertyName}!";

            public static string RecordAlreadyUpdated = "The record that you are trying to update is already updated by someone else. Please refresh and try again.";

            public static string UnableToDeleteRecord = "Unable to delete as there are configuration that reference to this record.";

            public static string SiteDivisionDoesNotExists(int id) => $"SiteDivision with Site Id {id} does not exists.";

            public static string SiteWorkCellDoesNotExists(int id) => $"SiteWorkCell with Site Id {id} does not exists.";

            public static string WorkCellSiteDoesNotExists(int id) => $"WorkCellSite with WorkCell Id {id} does not exists.";

            public static string SiteDepartmentDoesNotExists(int id) => $"SiteDepartment with Site Id {id} does not exists.";

            public static string SiteUserDoesNotExists(int id) => $"SiteUser with Site Id {id} does not exists.";

            public static string InspectionToolsTypePcCodeDoesNotExists(int id) => $"InspectionToolsTypePcCode with InspectionToolsType Id {id} does not exists.";

            public static string NameAlreadyExists= "Name has been taken. Please specify a different Name!";

            public static string ParameterManagementCommodityNameIdCodeDoesNotExists(int id) => $"Parameter Management Commodity Name with Parameter Management Id {id} does not exists.";

            public static string TestReportCommodityDoesNotExists(int id) => $"TestReportCommodity with TestReport Id {id} does not exists.";

            public static string ParameterTypeCodeIdCodeDoesNotExists(int id) => $"Parameter Type Code Name with Parameter Type Code Id {id} does not exists.";

            public static string WorkCellJabilUserDoesNotExists(int id) => $"Work Cell Jabil User Name with Material Group Jabil User Id {id} does not exists.";

            public static string WorkCellDccUserDoesNotExists(int id) => $"Work Cell Dcc User Name with Material Group Dcc User Id {id} does not exists.";

            public static string SAPPartInspectionPlanSupplierDoesNotExists(int id) => $"Part Inspection Plan with Supplier Id {id} does not exists.";

            public static string SAPPartInspectionPlanAdminCertificationDoesNotExists(int id) => $"Part Inspection Plan with Admin Certificate Id {id} does not exists.";

            public static string PartInspectionManufacturePartNumberDoesNotExists(int id) => $"Part Inspection Plan with Manufacture Part Number Id {id} does not exists.";

            public static string SAPPartInspectionPlanSamplingPlanDoesNotExists(int id) => $"Part Inspection Plan with Sampling Plan Id {id} does not exists.";

            public static string CertificateTypeParameterDoesNotExists(int id) => $"CertificateTypeParameter with CertificateType Id {id} does not exists.";

            public static string SupplierMeasurementSubmissionManufacturePartNumberDoesNotExists(int id) => $"Supplier Measurement with PartNumber Id {id} does not exists.";

            public static string DefectTypeDoesNotExists(int id) => $"Defect Type with Defect Type Id {id} does not exists.";

        }


        internal static class PostgresErrorCode
        {
            public const string PostgresUnableToDelete = "23503";
        }
        internal static class DefaultUser
        {
            public const int UserId = 1;
        }
    }
}
