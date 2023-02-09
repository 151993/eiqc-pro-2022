

using System.Collections.Generic;

namespace QSS.Infrastructure.Core.QSSGatewayAPI.Model
{
    public class TM1SiteModel: TM1Model
    {
        public List<SitePlantCode> SitePlantCode { get; set; }

    }

    public class SitePlantCode
    {
        public TM1Model PlantCode { get; set; }
    }
}
