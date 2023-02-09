using OData.QueryBuilder.Builders;
using OData.QueryBuilder.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.OdataHelper
{
    public class ODataBuilder<TResource> where TResource: class
    {

        private const string BaseOdataAddress = "http://localhost:8001/odata";
        public ODataQueryBuilder<ODataInfoContainer<TResource>> GetODataQueryBuilder()
        {
            var builder = new ODataQueryBuilder<ODataInfoContainer<TResource>>(BaseOdataAddress, new ODataQueryBuilderOptions
            {
                SuppressExceptionOfNullOrEmptyFunctionArgs = true,
                SuppressExceptionOfNullOrEmptyOperatorArgs = true,
            });

            return builder;
        }
    }
}
