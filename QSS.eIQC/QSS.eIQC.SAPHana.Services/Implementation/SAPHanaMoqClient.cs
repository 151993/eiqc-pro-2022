
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPHana.Services.SAPModels;
using QSS.eIQC.Utilities.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.SAPHana.Services.Implementation
{
    public class SAPHanaMoqClient : ISAPHanaClient
    {
        private const string SAPPartFile = "PartData";
        private const string FolderName = "MoqData";
        private const string SAPCommodityNamesFile = "CommodityNames";
        private const string SAPCommodityCategoryFile = "CommodityCategory";
        private const string SAPAppearanceInspectionItemFile = "AppearanceInspectionItem";
        private const string SAPFunctionTestItemFile = "FunctionTestItem";
        private const string SAPMaterialGroupFile = "MaterialGroup";
        private const string SAPCommodityFile = "Commodity";
        private const string SAPSupplierFile = "SupplierData";

        public IEnumerable<SAPMockPartModel> GetPartData()
        {
            return JsonDeserializer.DeserializerObject<SAPMockPartModel>(SAPPartFile, FolderName);       
        }

        public IEnumerable<CommodityNames> GetCommodityNames()
        {
            IEnumerable<CommodityNames> sapCommodityNames = JsonDeserializer.DeserializerObject<CommodityNames>(SAPCommodityNamesFile, FolderName);
            return sapCommodityNames;
        }


        public IEnumerable<CommodityCategory> GetCommodityCategory()
        {
            IEnumerable<CommodityCategory> sapCommodityCategory = JsonDeserializer.DeserializerObject<CommodityCategory>(SAPCommodityCategoryFile, FolderName);
            return sapCommodityCategory;
        }


        public IEnumerable<AppearanceInspectionItem> GetAppearanceInspectionItem()
        {
            IEnumerable<AppearanceInspectionItem> sapAppearanceInspectionItems = JsonDeserializer.DeserializerObject<AppearanceInspectionItem>(SAPAppearanceInspectionItemFile, FolderName);
            return sapAppearanceInspectionItems;
        }

        public IEnumerable<FunctionTestItems> GetFunctionTestItems()
        {

            IEnumerable<FunctionTestItems> sapFunctionTestItems = JsonDeserializer.DeserializerObject<FunctionTestItems>(SAPFunctionTestItemFile, FolderName);
            return sapFunctionTestItems;
        }


        public async Task<IList<MaterialGroups>> GetMaterialGroupItems()
        {
            IList<MaterialGroups> sapMaterialGroupItems = JsonDeserializer.DeserializerObject<MaterialGroups>(SAPMaterialGroupFile, FolderName);
            return sapMaterialGroupItems;
        }

        public async Task<IList<SAPPartModel>> GetParts()
        {
            IList<SAPPartModel> sapParts = JsonDeserializer.DeserializerObject<SAPPartModel>(SAPPartFile, FolderName);
            return sapParts;
        }


        public async Task<IList<SAPCommodity>> GetCommodities()
        {
            IList<SAPCommodity> sapCommodities = JsonDeserializer.DeserializerObject<SAPCommodity>(SAPCommodityFile, FolderName);
            return sapCommodities;
        }

        public async Task<IList<SAPSupplierMoqModel>> GetSuppliers()
        {
            IList<SAPSupplierMoqModel> sapSuppliers = JsonDeserializer.DeserializerObject<SAPSupplierMoqModel>(SAPSupplierFile, FolderName);
            return sapSuppliers;
        }
    }
}

