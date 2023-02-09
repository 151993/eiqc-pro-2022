using QSS.eIQC.Domain.Enums;
using QSS.eIQC.SAPHana.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.SAPSync.Interface
{
    public interface ISyncSAPDataHelper
    {
        dynamic GetSAPLastSyncDate(SyncSAPDataType key);

        Task<bool> SyncMaterialGroup(IList<MaterialGroups> sapData);

        Task<bool> SyncPart(IList<SAPPartModel> sapData);

        Task<bool> SyncCommodity(IList<SAPCommodity> sapData);

        bool SyncSuppliers(IList<SAPSupplierModel> sapData, string valuationArea);

        Task<bool> SyncPurchaseOrders(IList<SAPPurchaseOrderModel> sapData);

    }
}
