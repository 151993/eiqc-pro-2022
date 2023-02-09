using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.OdataHelper
{
    public class ODataResponse<T>
    {
        public List<T> Value { get; set; }
    }
}
