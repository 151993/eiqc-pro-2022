using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum PermissionType
    {
        [Description("Admin_Can_Access")]
        AdminCanAccess = 1,
        
        #region Admin Role

        [Description("Admin_Role_Can_Access")]
        AdminRoleCanAccess = 2,
        [Description("Admin_Role_Can_Create")]
        AdminRoleCanCreate = 3,
        [Description("Admin_Role_Can_Update")]
        AdminRoleCanUpdate = 4,
        [Description("Admin_Role_Can_Delete")]
        AdminRoleCanDelete = 5,

        #endregion

        #region Admin User 

        [Description("Admin_User_Can_Access")]
        AdminUserCanAccess = 6,
        [Description("Admin_User_Can_Create")]
        AdminUserCanCreate = 7,
        [Description("Admin_User_Can_Update")]
        AdminUserCanUpdate = 8,
        [Description("Admin_User_Can_Delete")]
        AdminUserCanDelete = 9,

        #endregion

        #region Admin EmailTemplate 

        [Description("Admin_EmailTemplate_Can_Access")]
        AdminEmailTemplateCanAccess = 10,
        [Description("Admin_EmailTemplate_Can_Update")]
        AdminEmailTemplateCanUpdate = 11,

        #endregion

        #region Admin Department 

        [Description("Admin_Department_Can_Access")]
        AdminDepartmentCanAccess = 12,
        [Description("Admin_Department_Can_Create")]
        AdminDepartmentCanCreate = 13,
        [Description("Admin_Department_Can_Update")]
        AdminDepartmentCanUpdate = 14,
        [Description("Admin_Department_Can_Delete")]
        AdminDepartmentCanDelete = 15,


        #endregion

        #region Admin WorkCell 
 		[Description("Admin_WorkCell_Can_Access")]
        AdminWorkCellCanAccess = 16,
        [Description("Admin_WorkCell_Can_Create")]
        AdminWorkCellCanCreate = 17,
        [Description("Admin_WorkCell_Can_Update")]
        AdminWorkCellCanUpdate = 18,
        [Description("Admin_WorkCell_Can_Delete")]
        AdminWorkCellCanDelete = 19,

        #endregion		

        #region Admin Region 
        [Description("Admin_Region_Can_Access")]
        AdminRegionCanAccess = 20,
        [Description("Admin_Region_Can_Create")]
        AdminRegionCanCreate = 21,
        [Description("Admin_Region_Can_Update")]
        AdminRegionCanUpdate = 22,
        [Description("Admin_Region_Can_Delete")]
        AdminRegionCanDelete = 23,
        #endregion

        #region Admin Division
        [Description("Admin_Division_Can_Access")]
        AdminDivisionCanAccess =32,
        [Description("Admin_Division_Can_Create")]
        AdminDivisionCanCreate = 33,
        [Description("Admin_Division_Can_Update")]
        AdminDivisionCanUpdate = 34,
        [Description("Admin_Division_Can_Delete")]
        AdminDivisionCanDelete = 35,

        #endregion

        #region Admin Location 

        [Description("Admin_Location_Can_Access")]
        AdminLocationCanAccess = 36,
        [Description("Admin_Location_Can_Create")]
        AdminLocationCanCreate = 37,
        [Description("Admin_Location_Can_Update")]
        AdminLocationCanUpdate = 38,
        [Description("Admin_Location_Can_Delete")]
        AdminLocationCanDelete = 39,

        #endregion

        #region Admin Country  

        [Description("Admin_Country_Can_Access")]
        AdminCountryCanAccess = 28,
        [Description("Admin_Country_Can_Create")]
        AdminCountryCanCreate = 29,
        [Description("Admin_Country_Can_Update")]
        AdminCountryCanUpdate = 30,
        [Description("Admin_Country_Can_Delete")]
        AdminCountryCanDelete = 31,

        #endregion

        #region Admin Site  

        [Description("Admin_Site_Can_Access")]
        AdminSiteCanAccess = 24,
        [Description("Admin_Site_Can_Create")]
        AdminSiteCanCreate = 25,
        [Description("Admin_Site_Can_Update")]
        AdminSiteCanUpdate = 26,
        [Description("Admin_Site_Can_Delete")]
        AdminSiteCanDelete = 27,

        #endregion

        [Description("Home_Can_Access")]
        HomeCanAccess = 44,
        #region Admin AuditLog  

        [Description("Admin_AuditLog_Can_Access")]
        AdminAuditLogCanAccess = 45,

        #endregion

       

        #region Admin SiteUser

        [Description("Admin_SiteUser_Can_Access")]
        AdminSiteUserCanAccess = 40,
        [Description("Admin_SiteUser_Can_Create")]
        AdminSiteUserCanCreate = 41,
        [Description("Admin_SiteUser_Can_Update")]
        AdminSiteUserCanUpdate = 42,
        [Description("Admin_SiteUser_Can_Delete")]
        AdminSiteUserCanDelete = 43,

        #endregion


        #region Admin Buyer

        [Description("Admin_Buyer_Can_Access")]
        AdminBuyerCanAccess = 50,
        [Description("Admin_Buyer_Can_Create")]
        AdminBuyerCanCreate = 51,
        [Description("Admin_Buyer_Can_Update")]
        AdminBuyerCanUpdate = 52,
        [Description("Admin_Buyer_Can_Delete")]
        AdminBuyerCanDelete = 53,

        #endregion

        #region Admin CompletedGRS

        [Description("Admin_CompletedGRS_Can_Access")]
        AdminCompletedGRSCanAccess = 54,
        [Description("Admin_CompletedGRS_Can_Create")]
        AdminCompletedGRSCanCreate = 55,
        [Description("Admin_CompletedGRS_Can_Update")]
        AdminCompletedGRSCanUpdate = 56,
        [Description("Admin_CompletedGRS_Can_Delete")]
        AdminCompletedGRSCanDelete = 57,

        #endregion

        #region Admin Customer

        [Description("Admin_Customer_Can_Access")]
        AdminCustomerCanAccess = 58,
        [Description("Admin_Customer_Can_Create")]
        AdminCustomerCanCreate = 59,
        [Description("Admin_Customer_Can_Update")]
        AdminCustomerCanUpdate = 60,
        [Description("Admin_Customer_Can_Delete")]
        AdminCustomerCanDelete = 61,

        #endregion

        #region Admin DefectType

        [Description("Admin_DefectType_Can_Access")]
        AdminDefectTypeCanAccess = 62,
        [Description("Admin_DefectType_Can_Create")]
        AdminDefectTypeCanCreate = 63,
        [Description("Admin_DefectType_Can_Update")]
        AdminDefectTypeCanUpdate = 64,
        [Description("Admin_DefectType_Can_Delete")]
        AdminDefectTypeCanDelete = 65,

        #endregion

        #region Admin CTParameter

        [Description("Admin_CTParameter_Can_Access")]
        AdminCTParameterCanAccess = 66,
        [Description("Admin_CTParameter_Can_Create")]
        AdminCTParameterCanCreate = 67,
        [Description("Admin_CTParameter_Can_Update")]
        AdminCTParameterCanUpdate = 68,
        [Description("Admin_CTParameter_Can_Delete")]
        AdminCTParameterCanDelete = 69,

        #endregion
       

        #region Admin UOM

        [Description("Admin_UOM_Can_Access")]
        AdminUOMCanAccess = 70,
        [Description("Admin_UOM_Can_Create")]
        AdminUOMCanCreate =71,
        [Description("Admin_UOM_Can_Update")]
        AdminUOMCanUpdate =72,
        [Description("Admin_UOM_Can_Delete")]
        AdminUOMCanDelete= 73,
        #endregion

        #region Admin GoodsReceiveUser

        [Description("Admin_GoodsReceiveUser_Can_Access")]
        AdminGoodsReceiveUserUOMCanAccess = 74,
        [Description("Admin_GoodsReceiveUser_Can_Create")]
        AdminGoodsReceiveUserCanCreate = 75,
        [Description("Admin_GoodsReceiveUser_Can_Update")]
        AdminGoodsReceiveUserCanUpdate = 76,
        [Description("Admin_GoodsReceiveUser_Can_Delete")]
        AdminGoodsReceiveUserCanDelete = 77,
        #endregion

        #region Admin Group

        [Description("Admin_Group_Can_Access")]
        AdminGroupCanAccess = 78,
        [Description("Admin_Group_Can_Create")]
        AdminGroupCanCreate = 79,  
        [Description("Admin_Group_Can_Update")]
        AdminGroupCanUpdate= 80,  
        [Description("Admin_Group_Can_Delete")]
        AdminGroupCanDelete = 81,
        #endregion

        #region Admin InspectionToolsType

        [Description("Admin_InspectionToolsType_Can_Access")]
        AdminInspectionToolsTypeCanAccess = 82,
        [Description("Admin_InspectionToolsType_Can_Create")]
        AdminInspectionToolsTypeCanCreate = 83,
        [Description("Admin_InspectionToolsType_Can_Update")]
        AdminInspectionToolsTypeCanUpdate = 84,
        [Description("Admin_InspectionToolsType_Can_Delete")]
        AdminInspectionToolsTypeCanDelete = 85,
        #endregion

        #region Admin InstrumentType

        [Description("Admin_InstrumentType_Can_Access")]
        AdminInstrumentTypeCanAccess = 86,
        [Description("Admin_InstrumentType_Can_Create")]
        AdminInstrumentTypeCanCreate = 87,
        [Description("Admin_InstrumentType_Can_Update")]
        AdminInstrumentTypeCanUpdate = 88,
        [Description("Admin_InstrumentType_Can_Delete")]
        AdminInstrumentTypeCanDelete = 89,
        #endregion

        #region Admin GRSSAPResult

        [Description("Admin_GRSSAPResult_Can_Access")]
        AdminGRSSAPResultCanAccess = 90,
        [Description("Admin_GRSSAPResult_Can_Create")]
        AdminGRSSAPResultCanCreate = 91,
        [Description("Admin_GRSSAPResult_Can_Update")]
        AdminGRSSAPResultCanUpdate = 92,
        [Description("Admin_GRSSAPResult_Can_Delete")]
        AdminGRSSAPResultCanDelete = 93,
        #endregion


        #region Admin LotInspectionQty

        [Description("Admin_LotInspectionQty_Can_Access")]
        AdminLotInspectionQtyCanAccess = 94,
        [Description("Admin_LotInspectionQty_Can_Create")]
        AdminLotInspectionQtyCanCreate = 95,
        [Description("Admin_LotInspectionQty_Can_Update")]
        AdminLotInspectionQtyCanUpdate = 96,
        [Description("Admin_LotInspectionQty_Can_Delete")]
        AdminLotInspectionQtyCanDelete = 97,
        #endregion

        #region Admin ParameterType

        [Description("Admin_ParameterType_Can_Access")]
        AdminParameterTypeCanAccess = 98,
        [Description("Admin_ParameterType_Can_Create")]
        AdminParameterTypeCanCreate = 99,
        [Description("Admin_ParameterType_Can_Update")]
        AdminParameterTypeCanUpdate = 100,
        [Description("Admin_ParameterType_Can_Delete")]
        AdminParameterTypeCanDelete = 101,
        #endregion

        #region Admin ParameterCategory

        [Description("Admin_ParameterCategory_Can_Access")]
        AdminParameterCategoryCanAccess = 102,
        [Description("Admin_ParameterCategory_Can_Create")]
        AdminParameterCategoryCanCreate = 103,
        [Description("Admin_ParameterCategory_Can_Update")]
        AdminParameterCategoryCanUpdate = 104,
        [Description("Admin_ParameterCategory_Can_Delete")]
        AdminParameterCategoryCanDelete = 105,
        #endregion

        #region Admin PartCAF

        [Description("Admin_PartCAF_Can_Access")]
        AdminPartCAFCanAccess = 106,
        [Description("Admin_PartCAF_Can_Create")]
        AdminPartCAFCanCreate = 107,
        [Description("Admin_PartCAF_Can_Update")]
        AdminPartCAFCanUpdate = 108,
        [Description("Admin_PartCAF_Can_Delete")]
        AdminPartCAFCanDelete = 109,
        #endregion

        #region Admin PCCode

        [Description("Admin_PCCode_Can_Access")]
        AdminPCCodeCanAccess = 110,
        [Description("Admin_PCCode_Can_Create")]
        AdminPCCodeCanCreate = 111,
        [Description("Admin_PCCode_Can_Update")]
        AdminPCCodeCanUpdate = 112,
        [Description("Admin_PCCode_Can_Delete")]
        AdminPCCodeCanDelete = 113,
        #endregion

        #region Admin ReceiveGoodsInfo

        [Description("Admin_ReceiveGoodsInfo_Can_Access")]
        AdminReceiveGoodsInfoCanAccess = 114,
        [Description("Admin_ReceiveGoodsInfo_Can_Create")]
        AdminReceiveGoodsInfoCanCreate = 115,
        [Description("Admin_ReceiveGoodsInfo_Can_Update")]
        AdminReceiveGoodsInfoCanUpdate = 116,
        [Description("Admin_ReceiveGoodsInfo_Can_Delete")]
        AdminReceiveGoodsInfoCanDelete = 117,
        #endregion

        #region Admin ReceiveGoodsInfoManual

        [Description("Admin_ReceiveGoodsInfoManual_Can_Access")]
        AdminReceiveGoodsInfoManualCanAccess = 118,
        [Description("Admin_ReceiveGoodsInfoManual_Can_Create")]
        AdminReceiveGoodsInfoManualCanCreate = 119,
        [Description("Admin_ReceiveGoodsInfoManual_Can_Update")]
        AdminReceiveGoodsInfoManualCanUpdate = 120,
        [Description("Admin_ReceiveGoodsInfoManual_Can_Delete")]
        AdminReceiveGoodsInfoManualCanDelete = 121,
        #endregion

        #region Admin Rosetta

        [Description("Admin_Rosetta_Can_Access")]
        AdminRosettaCanAccess = 122,
        [Description("Admin_Rosetta_Can_Create")]
        AdminRosettaCanCreate = 123,
        [Description("Admin_Rosetta_Can_Update")]
        AdminRosettaCanUpdate = 124,
        [Description("Admin_LotInspectionQty_Can_Delete")]
        AdminRosettaCanDelete = 125,
        #endregion        

        #region Admin DispositionType  

        [Description("Admin_DispositionType_Can_Access")]
        AdminDispositionTypeCanAccess = 126,
        [Description("Admin_DispositionType_Can_Create")]
        AdminDispositionTypeCanCreate = 127,
        [Description("Admin_DispositionType_Can_Update")]
        AdminDispositionTypeCanUpdate = 128,
        [Description("Admin_DispositionType_Can_Delete")]
        AdminDispositionTypeCanDelete = 129,

        #endregion

        #region Admin SupplierForm

        [Description("Admin_SupplierForm_Can_Access")]
        AdminSupplierFormCanAccess = 130,
        [Description("Admin_SupplierForm_Can_Create")]
        AdminSupplierFormCanCreate = 131,
        [Description("Admin_SupplierForm_Can_Update")]
        AdminSupplierFormCanUpdate = 132,
        [Description("Admin_SupplierForm_Can_Delete")]
        AdminSupplierFormCanDelete = 133,
        #endregion

        #region Admin SupplierFormVIS

        [Description("Admin_SupplierFormVIS_Can_Access")]
        AdminSupplierFormVISCanAccess = 134,
        [Description("Admin_SupplierFormVIS_Can_Create")]
        AdminSupplierFormVISCanCreate = 135,
        [Description("Admin_SupplierFormVIS_Can_Update")]
        AdminSupplierFormVISCanUpdate = 136,
        [Description("Admin_SupplierFormVIS_Can_Delete")]
        AdminSupplierFormVISCanDelete = 137,
        #endregion

        #region Admin SupplierFormCountParameter  

        [Description("Admin_SupplierFormCountParameter_Can_Access")]
        AdminSupplierFormCountParameterCanAccess = 138,
        [Description("Admin_SupplierFormCountParameter_Can_Create")]
        AdminSupplierFormCountParameterCanCreate = 139,
        [Description("Admin_SupplierFormCountParameter_Can_Update")]
        AdminSupplierFormCountParameterCanUpdate = 140,
        [Description("Admin_SupplierFormCountParameter_Can_Delete")]
        AdminSupplierFormCountParameterCanDelete = 141,

        #endregion

        #region Admin SupplierTestReport  

        [Description("Admin_SupplierTestReport_Can_Access")]
        AdminSupplierTestReportCanAccess = 142,
        [Description("Admin_SupplierTestReport_Can_Create")]
        AdminSupplierTestReportCanCreate = 143,
        [Description("Admin_SupplierTestReport_Can_Update")]
        AdminSupplierTestReportCanUpdate = 144,
        [Description("Admin_SupplierTestReport_Can_Delete")]
        AdminSupplierTestReportCanDelete = 145,

        #endregion

        #region Admin SupplierFormSAPParameter  

        [Description("Admin_SupplierFormSAPParameter_Can_Access")]
        AdminSupplierFormSAPParameterCanAccess = 146,
        [Description("Admin_SupplierFormSAPParameter_Can_Create")]
        AdminSupplierFormSAPParameterCanCreate = 147,
        [Description("Admin_SupplierFormSAPParameter_Can_Update")]
        AdminSupplierFormSAPParameterCanUpdate = 148,
        [Description("Admin_SupplierFormSAPParameter_Can_Delete")]
        AdminSupplierFormSAPParameterCanDelete = 149,

        #endregion

        #region Admin SupplierFormBowTwistParameter  

        [Description("Admin_SupplierFormBowTwistParameter_Can_Access")]
        AdminSupplierFormBowTwistParameterCanAccess = 150,
        [Description("Admin_SupplierFormBowTwistParameter_Can_Create")]
        AdminSupplierFormBowTwistParameterCanCreate = 151,
        [Description("Admin_SupplierFormBowTwistParameter_Can_Update")]
        AdminSupplierFormBowTwistParameterCanUpdate = 152,
        [Description("Admin_SupplierFormBowTwistParameter_Can_Delete")]
        AdminSupplierFormBowTwistParameterCanDelete = 153,

        #endregion

        #region Admin SupplierFormSpecialParameter  

        [Description("Admin_SupplierFormSpecialParameter_Can_Access")]
        AdminSupplierFormSpecialParameterCanAccess = 154,
        [Description("Admin_SupplierFormSpecialParameter_Can_Create")]
        AdminSupplierFormSpecialParameterCanCreate = 155,
        [Description("Admin_SupplierFormSpecialParameter_Can_Update")]
        AdminSupplierFormSpecialParameterCanUpdate = 156,
        [Description("Admin_SupplierFormSpecialParameter_Can_Delete")]
        AdminSupplierFormSpecialParameterCanDelete = 157,

        #endregion

        #region Admin SupplierFormResultOrientedParameter  

        [Description("Admin_SupplierFormResultOrientedParameter_Can_Access")]
        AdminSupplierFormResultOrientedParameterCanAccess = 158,
        [Description("Admin_SupplierFormResultOrientedParameter_Can_Create")]
        AdminSupplierFormResultOrientedParameterCanCreate = 159,
        [Description("Admin_SupplierFormResultOrientedParameter_Can_Update")]
        AdminSupplierFormResultOrientedParameterCanUpdate = 160,
        [Description("Admin_SupplierFormResultOrientedParameter_Can_Delete")]
        AdminSupplierFormResultOrientedParameterCanDelete = 161,

        #endregion

        #region Admin SupplierFormPackaging  

        [Description("Admin_SupplierFormPackaging_Can_Access")]
        AdminSupplierFormPackagingCanAccess = 162,
        [Description("Admin_SupplierFormPackaging_Can_Create")]
        AdminSupplierFormPackagingCanCreate = 163,
        [Description("Admin_SupplierFormPackaging_Can_Update")]
        AdminSupplierFormPackagingCanUpdate =164,
        [Description("Admin_SupplierFormPackaging_Can_Delete")]
        AdminSupplierFormPackagingCanDelete = 165,

        #endregion

        #region Admin SupplierFormPartDateCode  

        [Description("Admin_SupplierFormPartDateCode_Can_Access")]
        AdminSupplierFormPartDateCodeCanAccess = 166,
        [Description("Admin_SupplierFormPartDateCode_Can_Create")]
        AdminSupplierFormPartDateCodeCanCreate = 167,
        [Description("Admin_SupplierFormPartDateCode_Can_Update")]
        AdminSupplierFormPartDateCodeCanUpdate = 168,
        [Description("Admin_SupplierFormPartDateCode_Can_Delete")]
        AdminSupplierFormPartDateCodeCanDelete = 169,

        #endregion

        #region Admin SupplierFormBowTwistActual  

        [Description("Admin_SupplierFormBowTwistActual_Can_Access")]
        AdminSupplierFormBowTwistActualCanAccess = 170,
        [Description("Admin_SupplierFormBowTwistActual_Can_Create")]
        AdminSupplierFormBowTwistActualCanCreate = 171,
        [Description("Admin_SupplierFormBowTwistActual_Can_Update")]
        AdminSupplierFormBowTwistActualCanUpdate = 172,
        [Description("Admin_SupplierFormBowTwistActual_Can_Delete")]
        AdminSupplierFormBowTwistActualCanDelete = 173,

        #endregion

        #region Admin SupplierFormFunPara  

        [Description("Admin_SupplierFormFunPara_Can_Access")]
        AdminSupplierFormFunParaCanAccess = 174,
        [Description("Admin_SupplierFormFunPara_Can_Create")]
        AdminSupplierFormFunParaCanCreate = 175,
        [Description("Admin_SupplierFormFunPara_Can_Update")]
        AdminSupplierFormFunParaCanUpdate = 176,
        [Description("Admin_SupplierFormFunPara_Can_Delete")]
        AdminSupplierFormFunParaCanDelete = 177,

        #endregion

        #region Admin SupplierFormFunParaActual  

        [Description("Admin_SupplierFormFunParaActual_Can_Access")]
        AdminSupplierFormFunParaActualCanAccess = 178,
        [Description("Admin_SupplierFormFunParaActual_Can_Create")]
        AdminSupplierFormFunParaActualCanCreate = 179,
        [Description("Admin_SupplierFormFunParaActual_Can_Update")]
        AdminSupplierFormFunParaActualCanUpdate = 180,
        [Description("Admin_SupplierFormFunParaActual_Can_Delete")]
        AdminSupplierFormFunParaActualCanDelete = 181,

        #endregion

        #region Admin SupplierFormLPosition  


        [Description("Admin_SupplierFormLPosition_Can_Access")]
        AdminSupplierFormLPositionCanAccess = 182,
        [Description("Admin_SupplierFormLPosition_Can_Create")]
        AdminSupplierFormLPositionCanCreate = 183,
        [Description("Admin_SupplierFormLPosition_Can_Update")]
        AdminSupplierFormLPositionCanUpdate = 184,
        [Description("Admin_SupplierFormLPosition_Can_Delete")]
        AdminSupplierFormLPositionCanDelete = 185,

        #endregion

        #region Admin SupplierFormLPositionActual  

        [Description("Admin_SupplierFormLPositionActual_Can_Access")]
        AdminSupplierFormLPositionActualCanAccess = 186,
        [Description("Admin_SupplierFormLPositionActual_Can_Create")]
        AdminSupplierFormLPositionActualCanCreate = 187,
        [Description("Admin_SupplierFormLPositionActual_Can_Update")]
        AdminSupplierFormLPositionActualCanUpdate = 188,
        [Description("Admin_SupplierFormLPositionActual_Can_Delete")]
        AdminSupplierFormLPositionActualCanDelete = 189,

        #endregion

        #region Admin SupplierFormMeasurementParameter  

        [Description("Admin_SupplierFormMeasurementParameter_Can_Access")]
        AdminSupplierFormMeasurementParameterCanAccess = 190,
        [Description("Admin_SupplierFormMeasurementParameter_Can_Create")]
        AdminSupplierFormMeasurementParameterCanCreate = 191,
        [Description("Admin_SupplierFormMeasurementParameter_Can_Update")]
        AdminSupplierFormMeasurementParameterCanUpdate = 192,
        [Description("Admin_SupplierFormMeasurementParameter_Can_Delete")]
        AdminSupplierFormMeasurementParameterCanDelete = 193,

        #endregion

        #region Admin SupplierFormMeasurementParameterActual  

        [Description("Admin_SupplierFormMeasurementParameterActual_Can_Access")]
        AdminSupplierFormMeasurementParameterActualCanAccess = 194,
        [Description("Admin_SupplierFormMeasurementParameterActual_Can_Create")]
        AdminSupplierFormMeasurementParameterActualCanCreate = 195,
        [Description("Admin_SupplierFormMeasurementParameterActual_Can_Update")]
        AdminSupplierFormMeasurementParameterActualCanUpdate = 196,
        [Description("Admin_SupplierFormMeasurementParameterActual_Can_Delete")]
        AdminSupplierFormMeasurementParameterActualCanDelete = 197,

        #endregion

        #region Admin SupplierFormMicroSection  

        [Description("Admin_SupplierFormMicroSection_Can_Access")]
        AdminSupplierFormMicroSectionCanAccess = 198,
        [Description("Admin_SupplierFormMicroSection_Can_Create")]
        AdminSupplierFormMicroSectionCanCreate = 199,
        [Description("Admin_SupplierFormMicroSection_Can_Update")]
        AdminSupplierFormMicroSectionCanUpdate = 200,
        [Description("Admin_SupplierFormMicroSection_Can_Delete")]
        AdminSupplierFormMicroSectionCanDelete = 201,

        #endregion

        #region Admin SupplierFormMicroSectionActual  

        [Description("Admin_SupplierFormMicroSectionActual_Can_Access")]
        AdminSupplierFormMicroSectionActualCanAccess =202,
        [Description("Admin_SupplierFormMicroSectionActual_Can_Create")]
        AdminSupplierFormMicroSectionActualCanCreate = 203,
        [Description("Admin_SupplierFormMicroSectionActual_Can_Update")]
        AdminSupplierFormMicroSectionActualCanUpdate = 204,
        [Description("Admin_SupplierFormMicroSectionActual_Can_Delete")]
        AdminSupplierFormMicroSectionActualCanDelete = 205,

        #endregion

        #region Admin SupplierFormMPosition  

        [Description("Admin_SupplierFormMPosition_Can_Access")]
        AdminSupplierFormMPositionCanAccess = 206,
        [Description("Admin_SupplierFormMPosition_Can_Create")]
        AdminSupplierFormMPositionCanCreate = 207,
        [Description("Admin_SupplierFormMPosition_Can_Update")]
        AdminSupplierFormMPositionCanUpdate = 208,
        [Description("Admin_SupplierFormMPosition_Can_Delete")]
        AdminSupplierFormMPositionCanDelete = 209,

        #endregion

        #region Admin SupplierFormMPositionActual  

        [Description("Admin_SupplierFormMPositionActual_Can_Access")]
        AdminSupplierFormMPositionActualCanAccess = 210,
        [Description("Admin_SupplierFormMPositionActual_Can_Create")]
        AdminSupplierFormMPositionActualCanCreate = 211,
        [Description("Admin_SupplierFormMPositionActual_Can_Update")]
        AdminSupplierFormMPositionActualCanUpdate = 212,
        [Description("Admin_SupplierFormMPositionActual_Can_Delete")]
        AdminSupplierFormMPositionActualCanDelete = 213,

        #endregion

        #region Admin SupplierAttachment  

        [Description("Admin_SupplierAttachment_Can_Access")]
        AdminSupplierAttachmentCanAccess = 214,
        [Description("Admin_SupplierAttachment_Can_Create")]
        AdminSupplierAttachmentCanCreate = 215,
        [Description("Admin_SupplierAttachment_Can_Update")]
        AdminSupplierAttachmentCanUpdate = 216,
        [Description("Admin_SupplierAttachment_Can_Delete")]
        AdminSupplierAttachmentCanDelete = 217,

        #endregion

        #region Admin Inspection  

        [Description("Admin_Inspection_Can_Access")]
        AdminInspectionCanAccess = 218,
        [Description("Admin_Inspection_Can_Create")]
        AdminInspectionCanCreate = 219,
        [Description("Admin_Inspection_Can_Update")]
        AdminInspectionCanUpdate = 220,
        [Description("Admin_Inspection_Can_Delete")]
        AdminInspectionCanDelete = 221,

        #endregion

        #region Admin InspectionTools  

        [Description("Admin_InspectionTools_Can_Access")]
        AdminInspectionToolsCanAccess = 222,
        [Description("Admin_InspectionTools_Can_Create")]
        AdminInspectionToolsCanCreate = 223,
        [Description("Admin_InspectionTools_Can_Update")]
        AdminInspectionToolsCanUpdate = 224,
        [Description("Admin_InspectionTools_Can_Delete")]
        AdminInspectionToolsCanDelete = 225,

        #endregion

        #region Admin Instrument  

        [Description("Admin_Instrument_Can_Access")]
        AdminInstrumentCanAccess = 226,
        [Description("Admin_Instrument_Can_Create")]
        AdminInstrumentCanCreate = 227,
        [Description("Admin_Instrument_Can_Update")]
        AdminInstrumentCanUpdate = 228,
        [Description("Admin_Instrument_Can_Delete")]
        AdminInstrumentCanDelete = 229,

        #endregion

        #region Admin GRS  

        [Description("Admin_GRS_Can_Access")]
        AdminGRSCanAccess = 230,
        [Description("Admin_GRS_Can_Create")]
        AdminGRSCanCreate = 231,
        [Description("Admin_GRS_Can_Update")]
        AdminGRSCanUpdate = 232,
        [Description("Admin_GRS_Can_Delete")]
        AdminGRSCanDelete = 233,

        #endregion

        #region Admin SAPPartInspectionPlan  

        [Description("Admin_SAPPartInspectionPlan_Can_Access")]
        AdminSAPPartInspectionPlanCanAccess = 234,
        [Description("Admin_SAPPartInspectionPlan_Can_Create")]
        AdminSAPPartInspectionPlanCanCreate = 235,
        [Description("Admin_SAPPartInspectionPlan_Can_Update")]
        AdminSAPPartInspectionPlanCanUpdate = 236,
        [Description("Admin_SAPPartInspectionPlan_Can_Delete")]
        AdminSAPPartInspectionPlanCanDelete = 237,

        #endregion

        #region Admin PCCodeInspectionToolsType  

        [Description("Admin_PCCodeInspectionToolsType_Can_Access")]
        AdminPCCodeInspectionToolsTypeCanAccess = 238,
        [Description("Admin_PCCodeInspectionToolsType_Can_Create")]
        AdminPCCodeInspectionToolsTypeCanCreate = 239,
        [Description("Admin_PCCodeInspectionToolsType_Can_Update")]
        AdminPCCodeInspectionToolsTypeCanUpdate = 240,
        [Description("Admin_PCCodeInspectionToolsType_Can_Delete")]
        AdminPCCodeInspectionToolsTypeCanDelete = 241,

        #endregion

        #region Admin GRSSupplierForm  

        [Description("Admin_GRSSupplierForm_Can_Access")]
        AdminGRSSupplierFormCanAccess = 242,
        [Description("Admin_GRSSupplierForm_Can_Create")]
        AdminGRSSupplierFormCanCreate = 243,
        [Description("Admin_GRSSupplierForm_Can_Update")]
        AdminGRSSupplierFormCanUpdate = 244,
        [Description("Admin_GRSSupplierForm_Can_Delete")]
        AdminGRSSupplierFormCanDelete = 245,

        #endregion

        #region Admin Part  

        [Description("Admin_Part_Can_Access")]
        AdminPartCanAccess = 246,
        [Description("Admin_Part_Can_Create")]
        AdminPartCanCreate = 247,
        [Description("Admin_Part_Can_Update")]
        AdminPartCanUpdate = 248,

        #endregion

        #region Admin PartBowTwistParameter  

        [Description("Admin_PartBowTwistParameter_Can_Access")]
        AdminPartBowTwistParameterCanAccess = 250,
        [Description("Admin_PartBowTwistParameter_Can_Create")]
        AdminPartBowTwistParameterCanCreate = 251,
        [Description("Admin_PartBowTwistParameter_Can_Update")]
        AdminPartBowTwistParameterCanUpdate = 252,
        [Description("Admin_PartBowTwistParameter_Can_Delete")]
        AdminPartBowTwistParameterCanDelete = 253,

        #endregion

        #region Admin PartCountParameter  

        [Description("Admin_PartCountParameter_Can_Access")]
        AdminPartCountParameterCanAccess = 254,
        [Description("Admin_PartCountParameter_Can_Create")]
        AdminPartCountParameterCanCreate = 255,
        [Description("Admin_PartCountParameter_Can_Update")]
        AdminPartCountParameterCanUpdate = 256,
        [Description("Admin_PartCountParameter_Can_Delete")]
        AdminPartCountParameterCanDelete = 257,

        #endregion

        #region Admin PartDateCode  

        [Description("Admin_PartDateCode_Can_Access")]
        AdminPartDateCodeCanAccess = 258,
        [Description("Admin_PartDateCode_Can_Create")]
        AdminPartDateCodeCanCreate = 259,
        [Description("Admin_PartDateCode_Can_Update")]
        AdminPartDateCodeCanUpdate = 260,
        [Description("Admin_PartDateCode_Can_Delete")]
        AdminPartDateCodeCanDelete = 261,

        #endregion

        #region Admin PartFunParameter  

        [Description("Admin_PartFunParameter_Can_Access")]
        AdminPartFunParameterCanAccess = 262,
        [Description("Admin_PartFunParameter_Can_Create")]
        AdminPartFunParameterCanCreate = 263,
        [Description("Admin_PartFunParameter_Can_Update")]
        AdminPartFunParameterCanUpdate = 264,
        [Description("Admin_PartFunParameter_Can_Delete")]
        AdminPartFunParameterCanDelete = 265,

        #endregion

        #region Admin PartLPositionTolerance  

        [Description("Admin_PartLPositionTolerance_Can_Access")]
        AdminPartLPositionToleranceCanAccess = 266,
        [Description("Admin_PartLPositionTolerance_Can_Create")]
        AdminPartLPositionToleranceCanCreate = 267,
        [Description("Admin_PartLPositionTolerance_Can_Update")]
        AdminPartLPositionToleranceCanUpdate = 268,
        [Description("Admin_PartLPositionTolerance_Can_Delete")]
        AdminPartLPositionToleranceCanDelete = 269,

        #endregion

        #region Admin PartMeasurementParameter  

        [Description("Admin_PartMeasurementParameter_Can_Access")]
        AdminPartMeasurementParameterCanAccess = 270,
        [Description("Admin_PartMeasurementParameter_Can_Create")]
        AdminPartMeasurementParameterCanCreate = 271,
        [Description("Admin_PartMeasurementParameter_Can_Update")]
        AdminPartMeasurementParameterCanUpdate = 272,
        [Description("Admin_PartMeasurementParameter_Can_Delete")]
        AdminPartMeasurementParameterCanDelete = 273,

        #endregion

        #region Admin PartMicrosection  

        [Description("Admin_PartMicrosection_Can_Access")]
        AdminPartMicrosectionCanAccess = 274,
        [Description("Admin_PartMicrosection_Can_Create")]
        AdminPartMicrosectionCanCreate = 275,
        [Description("Admin_PartMicrosection_Can_Update")]
        AdminPartMicrosectionCanUpdate = 276,
        [Description("Admin_PartMicrosection_Can_Delete")]
        AdminPartMicrosectionCanDelete = 277,

        #endregion

        #region Admin PartMPositionTolerance  

        [Description("Admin_PartMPositionTolerance_Can_Access")]
        AdminPartMPositionToleranceCanAccess = 278,
        [Description("Admin_PartMPositionTolerance_Can_Create")]
        AdminPartMPositionToleranceCanCreate = 279,
        [Description("Admin_PartMPositionTolerance_Can_Update")]
        AdminPartMPositionToleranceCanUpdate = 280,
        [Description("Admin_PartMPositionTolerance_Can_Delete")]
        AdminPartMPositionToleranceCanDelete = 281,

        #endregion

        #region Admin PartResultOrientedParameter  

        [Description("Admin_PartResultOrientedParameter_Can_Access")]
        AdminPartResultOrientedParameterCanAccess = 282,
        [Description("Admin_PartResultOrientedParameter_Can_Create")]
        AdminPartResultOrientedParameterCanCreate = 283,
        [Description("Admin_PartResultOrientedParameter_Can_Update")]
        AdminPartResultOrientedParameterCanUpdate = 284,
        [Description("Admin_PartResultOrientedParameter_Can_Delete")]
        AdminPartResultOrientedParameterCanDelete = 285,

        #endregion

        #region Admin PartTestReportParameter  

        [Description("Admin_PartTestReportParameter_Can_Access")]
        AdminPartTestReportParameterCanAccess = 286,
        [Description("Admin_PartTestReportParameter_Can_Create")]
        AdminPartTestReportParameterCanCreate = 287,
        [Description("Admin_PartTestReportParameter_Can_Update")]
        AdminPartTestReportParameterCanUpdate = 288,
        [Description("Admin_PartTestReportParameter_Can_Delete")]
        AdminPartTestReportParameterCanDelete = 289,

        #endregion

        #region Admin Form  

        [Description("Admin_Form_Can_Access")]
        AdminFormCanAccess = 290,
        [Description("Admin_Form_Can_Create")]
        AdminFormCanCreate = 291,
        [Description("Admin_Form_Can_Update")]
        AdminFormCanUpdate = 292,
        [Description("Admin_Form_Can_Delete")]
        AdminFormCanDelete = 293,

        #endregion

        #region Admin FormBowTwistParameter  

        [Description("Admin_FormBowTwistParameter_Can_Access")]
        AdminFormBowTwistParameterCanAccess = 294,
        [Description("Admin_FormBowTwistParameter_Can_Create")]
        AdminFormBowTwistParameterCanCreate = 295,
        [Description("Admin_FormBowTwistParameter_Can_Update")]
        AdminFormBowTwistParameterCanUpdate = 296,
        [Description("Admin_FormBowTwistParameter_Can_Delete")]
        AdminFormBowTwistParameterCanDelete = 297,

        #endregion

        #region Admin FormCountParameter  

        [Description("Admin_FormCountParameter_Can_Access")]
        AdminFormCountParameterCanAccess = 298,
        [Description("Admin_FormCountParameter_Can_Create")]
        AdminFormCountParameterCanCreate = 299,
        [Description("Admin_FormCountParameter_Can_Update")]
        AdminFormCountParameterCanUpdate = 300,
        [Description("Admin_FormCountParameter_Can_Delete")]
        AdminFormCountParameterCanDelete = 301,

        #endregion

        #region Admin FormFunPara  

        [Description("Admin_FormFunPara_Can_Access")]
        AdminFormFunParaCanAccess = 302,
        [Description("Admin_FormFunPara_Can_Create")]
        AdminFormFunParaCanCreate =303,
        [Description("Admin_FormFunPara_Can_Update")]
        AdminFormFunParaCanUpdate = 304,
        [Description("Admin_FormFunPara_Can_Delete")]
        AdminFormFunParaCanDelete = 305,

        #endregion

        #region Admin FormFunParaActual  

        [Description("Admin_FormFunParaActual_Can_Access")]
        AdminFormFunParaActualCanAccess = 306,
        [Description("Admin_FormFunParaActual_Can_Create")]
        AdminFormFunParaActualCanCreate = 307,
        [Description("Admin_FormFunParaActual_Can_Update")]
        AdminFormFunParaActualCanUpdate = 308,
        [Description("Admin_FormFunParaActual_Can_Delete")]
        AdminFormFunParaActualCanDelete = 309,

        #endregion

        #region Admin FormLPosition  

        [Description("Admin_FormLPosition_Can_Access")]
        AdminFormLPositionCanAccess = 310,
        [Description("Admin_FormLPosition_Can_Create")]
        AdminFormLPositionCanCreate = 311,
        [Description("Admin_FormLPosition_Can_Update")]
        AdminFormLPositionCanUpdate = 312,
        [Description("Admin_FormLPosition_Can_Delete")]
        AdminFormLPositionCanDelete = 313,

        #endregion

        #region Admin FormLPositionActual  

        [Description("Admin_FormLPositionActual_Can_Access")]
        AdminFormLPositionActualCanAccess = 314,
        [Description("Admin_FormLPositionActual_Can_Create")]
        AdminFormLPositionActualCanCreate =315,
        [Description("Admin_FormLPositionActual_Can_Update")]
        AdminFormLPositionActualCanUpdate = 316,
        [Description("Admin_FormLPositionActual_Can_Delete")]
        AdminFormLPositionActualCanDelete = 317,

        #endregion

        #region Admin FormMeasurementParameter  

        [Description("Admin_FormMeasurementParameter_Can_Access")]
        AdminFormMeasurementParameterCanAccess = 318,
        [Description("Admin_FormMeasurementParameter_Can_Create")]
        AdminFormMeasurementParameterCanCreate = 319,
        [Description("Admin_FormMeasurementParameter_Can_Update")]
        AdminFormMeasurementParameterCanUpdate = 320,
        [Description("Admin_FormMeasurementParameter_Can_Delete")]
        AdminFormMeasurementParameterCanDelete = 321,

        #endregion

        #region Admin FormMeasurementParameterActual  

        [Description("Admin_FormMeasurementParameterActual_Can_Access")]
        AdminFormMeasurementParameterActualCanAccess = 322,
        [Description("Admin_FormMeasurementParameterActual_Can_Create")]
        AdminFormMeasurementParameterActualCanCreate = 323,
        [Description("Admin_FormMeasurementParameterActual_Can_Update")]
        AdminFormMeasurementParameterActualCanUpdate = 324,
        [Description("Admin_FormMeasurementParameterActual_Can_Delete")]
        AdminFormMeasurementParameterActualCanDelete = 325,

        #endregion

        #region Admin FormBowTwistActual  

        [Description("Admin_FormBowTwistActual_Can_Access")]
        AdminFormBowTwistActualCanAccess = 326,
        [Description("Admin_FormBowTwistActual_Can_Create")]
        AdminFormBowTwistActualCanCreate = 327,
        [Description("Admin_FormBowTwistActual_Can_Update")]
        AdminFormBowTwistActualCanUpdate = 328,
        [Description("Admin_FormBowTwistActual_Can_Delete")]
        AdminFormBowTwistActualCanDelete = 329,

        #endregion

        #region Admin FormMicroSection  

        [Description("Admin_FormMicroSection_Can_Access")]
        AdminFormMicroSectionCanAccess = 330,
        [Description("Admin_FormMicroSection_Can_Create")]
        AdminFormMicroSectionCanCreate = 331,
        [Description("Admin_FormMicroSection_Can_Update")]
        AdminFormMicroSectionCanUpdate = 332,
        [Description("Admin_FormMicroSection_Can_Delete")]
        AdminFormMicroSectionCanDelete = 333,

        #endregion

        #region Admin FormMicroSectionActual  

        [Description("Admin_FormMicroSectionActual_Can_Access")]
        AdminFormMicroSectionActualCanAccess = 334,
        [Description("Admin_FormMicroSectionActual_Can_Create")]
        AdminFormMicroSectionActualCanCreate = 335,
        [Description("Admin_FormMicroSectionActual_Can_Update")]
        AdminFormMicroSectionActualCanUpdate = 336,
        [Description("Admin_FormMicroSectionActual_Can_Delete")]
        AdminFormMicroSectionActualCanDelete = 337,

        #endregion

        #region Admin FormMPosition  

        [Description("Admin_FormMPosition_Can_Access")]
        AdminFormMPositionCanAccess = 338,
        [Description("Admin_FormMPosition_Can_Create")]
        AdminFormMPositionCanCreate = 339,
        [Description("Admin_FormMPosition_Can_Update")]
        AdminFormMPositionCanUpdate = 340,
        [Description("Admin_FormMPosition_Can_Delete")]
        AdminFormMPositionCanDelete = 341,

        #endregion

        #region Admin FormMPositionActual  

        [Description("Admin_FormMPositionActual_Can_Access")]
        AdminFormMPositionActualCanAccess = 342,
        [Description("Admin_FormMPositionActual_Can_Create")]
        AdminFormMPositionActualCanCreate = 343,
        [Description("Admin_FormMPositionActual_Can_Update")]
        AdminFormMPositionActualCanUpdate = 344,
        [Description("Admin_FormMPositionActual_Can_Delete")]
        AdminFormMPositionActualCanDelete = 345,

        #endregion

        #region Admin FormPackaging  

        [Description("Admin_FormPackaging_Can_Access")]
        AdminFormPackagingCanAccess = 346,
        [Description("Admin_FormPackaging_Can_Create")]
        AdminFormPackagingCanCreate = 347,
        [Description("Admin_FormPackaging_Can_Update")]
        AdminFormPackagingCanUpdate = 348,
        [Description("Admin_FormPackaging_Can_Delete")]
        AdminFormPackagingCanDelete = 349,

        #endregion

        #region Admin FormPartDateCode  

        [Description("Admin_FormPartDateCode_Can_Access")]
        AdminFormPartDateCodeCanAccess = 350,
        [Description("Admin_FormPartDateCode_Can_Create")]
        AdminFormPartDateCodeCanCreate = 351,
        [Description("Admin_FormPartDateCode_Can_Update")]
        AdminFormPartDateCodeCanUpdate = 352,
        [Description("Admin_FormPartDateCode_Can_Delete")]
        AdminFormPartDateCodeCanDelete = 353,

        #endregion

        #region Admin FormPartSAPFailedQty  

        [Description("Admin_FormPartSAPFailedQty_Can_Access")]
        AdminFormPartSAPFailedQtyCanAccess = 354,
        [Description("Admin_FormPartSAPFailedQty_Can_Create")]
        AdminFormPartSAPFailedQtyCanCreate = 355,
        [Description("Admin_FormPartSAPFailedQty_Can_Update")]
        AdminFormPartSAPFailedQtyCanUpdate = 356,
        [Description("Admin_FormPartSAPFailedQty_Can_Delete")]
        AdminFormPartSAPFailedQtyCanDelete = 357,

        #endregion

        #region Admin FormResultOrientedParameter  

        [Description("Admin_FormResultOrientedParameter_Can_Access")]
        AdminFormResultOrientedParameterCanAccess = 358,
        [Description("Admin_FormResultOrientedParameter_Can_Create")]
        AdminFormResultOrientedParameterCanCreate = 359,
        [Description("Admin_FormResultOrientedParameter_Can_Update")]
        AdminFormResultOrientedParameterCanUpdate = 360,
        [Description("Admin_FormResultOrientedParameter_Can_Delete")]
        AdminFormResultOrientedParameterCanDelete = 361,

        #endregion

        #region Admin FormSAPParameter  

        [Description("Admin_FormSAPParameter_Can_Access")]
        AdminFormSAPParameterCanAccess = 362,
        [Description("Admin_FormSAPParameter_Can_Create")]
        AdminFormSAPParameterCanCreate = 363,
        [Description("Admin_FormSAPParameter_Can_Update")]
        AdminFormSAPParameterCanUpdate = 364,
        [Description("Admin_FormSAPParameter_Can_Delete")]
        AdminFormSAPParameterCanDelete = 365,

        #endregion

        #region Admin FormSpecialParameter  

        [Description("Admin_FormSpecialParameter_Can_Access")]
        AdminFormSpecialParameterCanAccess = 366,
        [Description("Admin_FormSpecialParameter_Can_Create")]
        AdminFormSpecialParameterCanCreate = 367,
        [Description("Admin_FormSpecialParameter_Can_Update")]
        AdminFormSpecialParameterCanUpdate = 368,
        [Description("Admin_FormSpecialParameter_Can_Delete")]
        AdminFormSpecialParameterCanDelete = 369,

        #endregion

        #region Admin FormStatus  

        [Description("Admin_FormStatus_Can_Access")]
        AdminFormStatusCanAccess = 370,
        [Description("Admin_FormStatus_Can_Create")]
        AdminFormStatusCanCreate = 371,
        [Description("Admin_FormStatus_Can_Update")]
        AdminFormStatusCanUpdate = 372,
        [Description("Admin_FormStatus_Can_Delete")]
        AdminFormStatusCanDelete = 373,

        #endregion

        #region Admin FormTestReport  

        [Description("Admin_FormTestReport_Can_Access")]
        AdminFormTestReportCanAccess = 374,
        [Description("Admin_FormTestReport_Can_Create")]
        AdminFormTestReportCanCreate = 375,
        [Description("Admin_FormTestReport_Can_Update")]
        AdminFormTestReportCanUpdate = 376,
        [Description("Admin_FormTestReport_Can_Delete")]
        AdminFormTestReportCanDelete = 377,

        #endregion

        #region Admin FormVIS  

        [Description("Admin_FormVIS_Can_Access")]
        AdminFormVISCanAccess = 378,
        [Description("Admin_FormVIS_Can_Create")]
        AdminFormVISCanCreate = 379,
        [Description("Admin_FormVIS_Can_Update")]
        AdminFormVISCanUpdate = 380,
        [Description("Admin_FormVIS_Can_Delete")]
        AdminFormVISCanDelete = 381,

        #endregion
       

        #region Admin FormType  

        [Description("Admin_FormType_Can_Access")]
        AdminFormTypeCanAccess = 382,
        [Description("Admin_FormType_Can_Create")]
        AdminFormTypeCanCreate = 383,
        [Description("Admin_FormType_Can_Update")]
        AdminFormTypeCanUpdate = 384,
        [Description("Admin_FormType_Can_Delete")]
        AdminFormTypeCanDelete = 385,

        #endregion


        #region Admin Commodity

        [Description("Admin_Commodity_Can_Access")]
        AdminCommodityCanAccess = 386,
        [Description("Admin_Commodity_Can_Create")]
        AdminCommodityCanCreate = 387,
        [Description("Admin_Commodity_Can_Update")]
        AdminCommodityCanUpdate = 388,
        [Description("Admin_Commodity_Can_Delete")]
        AdminCommodityCanDelete = 389,

        #endregion


        #region Admin Certification  

        [Description("Admin_Certification_Can_Access")]
        AdminCertificationCanAccess = 390,
        [Description("Admin_Certification_Can_Create")]
        AdminCertificationCanCreate = 391,
        [Description("Admin_Certification_Can_Update")]
        AdminCertificationCanUpdate = 392,
        [Description("Admin_Certification_Can_Delete")]
        AdminCertificationCanDelete = 393,

        #endregion


        #region Admin MaterialGroup

        [Description("Admin_MaterialGroup_Can_Access")]
        AdminMaterialGroupCanAccess = 394,
        [Description("Admin_MaterialGroup_Can_Create")]
        AdminMaterialGroupCanCreate = 395,
        [Description("Admin_MaterialGroup_Can_Update")]
        AdminMaterialGroupCanUpdate = 396,
        [Description("Admin_MaterialGroup_Can_Delete")]
        AdminMaterialGroupCanDelete = 397,

        #endregion


        #region Admin ParameterManagement  

        [Description("Admin_ParameterManagement_Can_Access")]
        AdminParameterManagementCanAccess = 398,
        [Description("Admin_ParameterManagement_Can_Create")]
        AdminParameterManagementCanCreate = 399,
        [Description("Admin_ParameterManagement_Can_Update")]
        AdminParameterManagementCanUpdate = 400,
        [Description("Admin_ParameterManagement_Can_Delete")]
        AdminParameterManagementCanDelete = 401,

        #endregion

        #region Admin TestReport  

        [Description("Admin_TestReport_Can_Access")]
        AdminTestReportCanAccess = 402,
        [Description("Admin_TestReport_Can_Create")]
        AdminTestReportCanCreate = 403,
        [Description("Admin_TestReport_Can_Update")]
        AdminTestReportCanUpdate = 404,
        [Description("Admin_TestReport_Can_Delete")]
        AdminTestReportCanDelete = 405,

        #endregion

        #region Admin ParameterTypeCode  

        [Description("Admin_ParameterTypeCode_Can_Access")]
        AdminParameterTypeCodeCanAccess = 406,
        [Description("Admin_ParameterTypeCode_Can_Create")]
        AdminParameterTypeCodeCanCreate = 407,
        [Description("Admin_ParameterTypeCode_Can_Update")]
        AdminParameterTypeCodeCanUpdate = 408,
        [Description("Admin_ParameterTypeCode_Can_Delete")]
        AdminParameterTypeCodeCanDelete = 409,

        #endregion

        #region Admin WorkCellUser  

        [Description("Admin_WorkCellUser_Can_Access")]
        AdminWorkCellUserCanAccess = 414,
        [Description("Admin_WorkCellUser_Can_Create")]
        AdminWorkCellUserCanCreate = 415,
        [Description("Admin_WorkCellUser_Can_Update")]
        AdminWorkCellUserCanUpdate = 416,
        [Description("Admin_WorkCellUser_Can_Delete")]
        AdminWorkCellUserCanDelete = 417,

        #endregion

        #region Admin PartDimension  

        [Description("Admin_PartDimension_Can_Access")]
        AdminPartDimensionCanAccess = 418,
        [Description("Admin_PartDimension_Can_Create")]
        AdminPartDimensionCanCreate = 419,
        [Description("Admin_PartDimension_Can_Update")]
        AdminPartDimensionCanUpdate = 420,
        [Description("Admin_PartDimension_Can_Delete")]
        AdminPartDimensionCanDelete = 421,

        #endregion


        #region Admin BowTwistFormula

        [Description("Admin_BowTwistFormula_Can_Access")]
        AdminBowTwistFormulaCanAccess = 422,
        [Description("Admin_BowTwistFormula_Can_Create")]
        AdminBowTwistFormulaCanCreate = 423,
        [Description("Admin_BowTwistFormula_Can_Update")]
        AdminBowTwistFormulaCanUpdate = 424,
        [Description("Admin_BowTwistFormula_Can_Delete")]
        AdminBowTwistFormulaCanDelete = 425,

        #endregion

        #region Admin DCCConfiguration  

        [Description("Admin_DCCConfiguration_Can_Access")]
        AdminDCCConfigurationCanAccess = 426,
        [Description("Admin_DCCConfiguration_Can_Create")]
        AdminDCCConfigurationCanCreate = 427,
        [Description("Admin_DCCConfiguration_Can_Update")]
        AdminDCCConfigurationCanUpdate = 428,
        [Description("Admin_DCCConfiguration_Can_Delete")]
        AdminDCCConfigurationCanDelete = 429,

        #endregion

        #region Admin CommodityCategory  

        [Description("Admin_CommodityCategory_Can_Access")]
        AdminCommodityCategoryCanAccess = 430,
        [Description("Admin_CommodityCategory_Can_Create")]
        AdminCommodityCategoryCanCreate = 431,
        [Description("Admin_CommodityCategory_Can_Update")]
        AdminCommodityCategoryCanUpdate = 432,
        [Description("Admin_CommodityCategory_Can_Delete")]
        AdminCommodityCategoryCanDelete = 433,

        #endregion

        #region Admin Supplier

        [Description("Admin_Supplier_Can_Access")]
        AdminSupplierCanAccess = 434,
        [Description("Admin_Supplier_Can_Create")]
        AdminSupplierCanCreate = 435,
        [Description("Admin_Supplier_Can_Update")]
        AdminSupplierCanUpdate = 436,

        #endregion

        #region Admin NonJabilUser

        [Description("Admin_NonJabilUser_Can_Access")]
        AdminNonJabilUserCanAccess = 438,
        [Description("Admin_NonJabilUser_Can_Create")]
        AdminNonJabilUserCanCreate = 439,
        [Description("Admin_NonJabilUser_Can_Update")]
        AdminNonJabilUserCanUpdate = 440,
        [Description("Admin_NonJabilUser_Can_Delete")]
        AdminNonJabilUserCanDelete = 441,

        #endregion

        #region Admin Comments
        [Description("Admin_SAPPartInspectionPlanComment_Can_Access")]
        AdminSAPPartInspectionPlanCommentCanAccess = 442,
        [Description("Admin_SAPPartInspectionPlanComment_Can_Create")]
        AdminSAPPartInspectionPlanCommentCanCreate = 443,
        [Description("Admin_SAPPartInspectionPlanComment_Can_Update")]
        AdminSAPPartInspectionPlanCommentCanUpdate = 444,
        [Description("Admin_SAPPartInspectionPlanComment_Can_Delete")]
        AdminSAPPartInspectionPlanCommentCanDelete = 445,


        #endregion

        #region Admin Purchase Order

        [Description("Admin_PurchaseOrder_Can_Access")]
        AdminPurchaseOrderCanAccess = 446,
        [Description("Admin_PurchaseOrder_Can_Create")]
        AdminPurchaseOrderCanCreate = 447,
        [Description("Admin_PurchaseOrder_Can_Update")]
        AdminPurchaseOrderCanUpdate = 448,

        #endregion

        #region Admin CertificateType  

        [Description("Admin_CertificateType_Can_Access")]
        AdminCertificateTypeCanAccess = 450,
        [Description("Admin_CertificateType_Can_Create")]
        AdminCertificateTypeCanCreate = 451,
        [Description("Admin_CertificateType_Can_Update")]
        AdminCertificateTypeCanUpdate = 452,
        [Description("Admin_CertificateType_Can_Delete")]
        AdminCertificateTypeCanDelete = 453,

        #endregion

        #region Admin ApprovedPartInspectionPlan  

        [Description("Admin_ApprovedPartInspectionPlan_Can_Access")]
        AdminApprovedPartInspectionPlanCanAccess = 454,
        [Description("Admin_ApprovedPartInspectionPlan_Can_Create")]
        AdminApprovedPartInspectionPlanCanCreate = 455,
        [Description("Admin_ApprovedPartInspectionPlan_Can_Update")]
        AdminApprovedPartInspectionPlanCanUpdate = 456,
        [Description("Admin_ApprovedPartInspectionPlan_Can_Delete")]
        AdminApprovedPartInspectionPlanCanDelete = 457,
        #endregion

        #region Supplier Measurement Submission
        [Description("Admin_SupplierMeasurementSubmission_Can_Access")]
        AdminSupplierMeasurementSubmissionCanAccess = 458,
        [Description("Admin_SupplierMeasurementSubmission_Can_Create")]
        AdminSupplierMeasurementSubmissionCanCreate = 459,
        [Description("Admin_SupplierMeasurementSubmission_Can_Update")]
        AdminSupplierMeasurementSubmissionCanUpdate = 460,
        [Description("Admin_SupplierMeasurementSubmission_Can_Delete")]
        AdminSupplierMeasurementSubmissionCanDelete = 461,
        #endregion


        #region DefectManagement
        [Description("Admin_DefectManagement_Can_Access")]
        AdminDefectManagementCanAccess = 462,
        [Description("Admin_DefectManagement_Can_Create")]
        AdminDefectManagementCanCreate = 463,
        [Description("Admin_DefectManagement_Can_Update")]
        AdminDefectManagementCanUpdate = 464,
        [Description("Admin_DefectManagement_Can_Delete")]
        AdminDefectManagementCanDelete = 465,
        #endregion


        [Description("Admin_SampleSizeCalculation_Can_Access")]
        AdminSampleSizeCalculationCanAccess = 466,



        #region Admin SamplingPlan  

        [Description("Admin_SamplingPlan_Can_Access")]
        AdminSamplingPlanCanAccess = 467,
        #endregion


        [Description("Admin_SupplierTask_Can_Access")]
        AdminSupplierTaskCanAccess = 468,
        [Description("Admin_SupplierTask_Can_Create")]
        AdminSupplierTaskCanCreate = 469,
        [Description("Admin_SupplierTask_Can_Update")]
        AdminSupplierTaskCanUpdate = 470,
        [Description("Admin_SupplierTask_Can_Delete")]
        AdminSupplierTaskCanDelete = 471,


        [Description("Admin_DCCTask_Can_Access")]
        AdminDCCTaskCanAccess = 472,
        [Description("Admin_DCCTask_Can_Create")]
        AdminDCCTaskCanCreate = 473,
        [Description("Admin_DCCTask_Can_Update")]
        AdminDCCTaskCanUpdate = 474,
        [Description("Admin_DCCTask_Can_Delete")]
        AdminDCCTaskCanDelete = 475,


        [Description("Admin_SQETask_Can_Access")]
        AdminSQETaskCanAccess = 476,
        [Description("Admin_SQETask_Can_Create")]
        AdminSQETaskCanCreate = 477,
        [Description("Admin_SQETask_Can_Update")]
        AdminSQETaskCanUpdate = 478,
        [Description("Admin_SQETask_Can_Delete")]
        AdminSQETaskCanDelete = 479,

        [Description("Admin_SMSMyTask_Can_Access")]
        AdminSMSMyTaskCanAccess = 480,
        [Description("Admin_SMSMyTask_Can_Create")]
        AdminSMSMyTaskCanCreate = 481,
        [Description("Admin_SMSMyTask_Can_Update")]
        AdminSMSMyTaskCanUpdate = 482,
        [Description("Admin_SMSMyTask_Can_Delete")]
        AdminSMSMyTaskCanDelete = 483,


        [Description("Admin_SMSApproved_Can_Access")]
        AdminApprovedSupplierMeasurementCanAccess = 484,
        [Description("Admin_SMSApproved_Can_Create")]
        AdminApprovedSupplierMeasurementCanCreate = 485,
        [Description("Admin_SMSApproved_Can_Update")]
        AdminApprovedSupplierMeasurementCanUpdate = 486,
        [Description("Admin_SMSApproved_Can_Delete")]
        AdminApprovedSupplierMeasurementCanDelete = 487,
    }
}
