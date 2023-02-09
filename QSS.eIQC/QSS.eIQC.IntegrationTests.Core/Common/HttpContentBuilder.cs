using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.Common
{
    public class HttpContentBuilder<T> where T : class
    {
        public StringContent GetHttpContent(T entity)
        {
            return new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, Constants.MediaType.Json);
        }
    }
}
