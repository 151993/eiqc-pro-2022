using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.OdataHelper
{
    public static class OdataUrlFormatter
    {   
        public static string GetOdataUrl(Uri odatauri, string entityname)
        {
            return odatauri.ToString().Replace("Entity", entityname);
        }
        
    }
}
