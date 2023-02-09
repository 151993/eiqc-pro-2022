using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPHana.Services.SAPModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.SAPHana.Services.Interface
{
    public interface ISAPHanaClient
    {
        IEnumerable<SAPMockPartModel> GetPartData();

        IEnumerable<CommodityNames> GetCommodityNames();

        IEnumerable<CommodityCategory> GetCommodityCategory();

        IEnumerable<AppearanceInspectionItem> GetAppearanceInspectionItem();

        IEnumerable<FunctionTestItems> GetFunctionTestItems();

        Task<IList<MaterialGroups>> GetMaterialGroupItems();

        Task<IList<SAPPartModel>> GetParts();

        Task<IList<SAPCommodity>> GetCommodities();

        Task<IList<SAPSupplierMoqModel>> GetSuppliers();

    }
}
