using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QSS.eIQC.Domain.Enums
{
    public enum SyncTM1DataType
    {
        [Description("Last-Sync-TM1-Division")]
        Last_Sync_Division = 1,

        [Description("Last-Sync-TM1-Site")]
        Last_Sync_Site = 2
      
    }
}
