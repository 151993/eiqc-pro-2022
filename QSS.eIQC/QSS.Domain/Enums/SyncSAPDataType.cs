using System.ComponentModel;
namespace QSS.eIQC.Domain.Enums
{
    public enum SyncSAPDataType
    {
        [Description("Last-Sync-Material-Group")]
        Last_Sync_MaterialGroup = 1,

        [Description("Last-Sync-Part")]
        Last_Sync_Part = 2,

        [Description("Last-Sync-Commodity")]
        Last_Sync_Commodity = 3,

        [Description("Last-Sync-Supplier")]
        Last_Sync_Supplier = 4,

        [Description("Last-Sync-PurchaseOrder")]
        Last_Sync_PurchaseOrder = 5,

    }
}
