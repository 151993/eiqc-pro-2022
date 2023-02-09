using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Handlers.Commands.PartCommand;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using SAPHana.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Extensions.Client;
using QSS.eIQC.Api.Helpers.Extensions;

namespace QSS.eIQC.Api.Services.Implementation
{
    public class SAPPartService
    {
        /// <summary>
        /// Store QSSGatewayAPIClient, <see cref="QSSGatewayAPIClient"/>
        /// </summary>
        private readonly IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Store IMapper, <see cref="IMapper"/>
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SAPPartService> _logger;


        public SAPPartService(ILogger<SAPPartService> logger, IQSSGatewayAPIClient qssClient, IMapper mapper)
        {
            _qssClient = qssClient;
            _mapper = mapper;
            _logger = logger;
        }

        public PageResult<PartModel> Get(ODataQueryOptions queryOptions, Uri uri)
        {
            try
            {
                var query = _qssClient.GetParts();

                query = query.AddODataOptions<SitePartModel>(queryOptions, "SitePart");

                var sitePartData = query.ExecuteAsync<SitePartModel>().Result;
                var partData = _mapper.Map<IEnumerable<SitePartModel>, IEnumerable<PartModel>>(sitePartData.ToList());

                var sapResult = sitePartData as Microsoft.OData.Client.QueryOperationResponse;
                var pageResultData = new PageResult<PartModel>(partData, uri, sapResult.TotalCount);

                return pageResultData;
            }
            catch (Exception ex)
            {
                _logger.LogError($"SAPPartService : Get {ex.Message}");
                throw ex;
            }

        }

    }
}
