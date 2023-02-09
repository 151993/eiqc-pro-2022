using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.OdataHelper
{
    public class ODataInfoContainer<T> where T : class
    {
        public T Entity { get; set; }

    }
}
