using QSS.eIQC.Domain.Enums;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.TM1Sync.Interface
{
    public interface ISyncTM1DataHelper
    {
        DateTimeOffset GetTM1LastSyncDate(SyncTM1DataType key);

        Task<bool> SyncDivision(IList<TM1DivisionModel> tm1Data);

        Task<bool> SyncSite(IList<TM1SiteModel> tm1SiteData);

    }
}
