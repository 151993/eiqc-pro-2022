using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPSync.Interface;
using QSS.eIQC.TM1Sync.Interface;
using QSS.Helpers.Http;


namespace QSS.eIQC.Api.Controllers.MaterialGroup
{
    /// <summary>
    /// MaterialGroup Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class MaterialGroupController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<MaterialGroupController> _logger;
        private readonly ISAPHanaClient _sapHanaClient;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of MaterialGroupController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="syncSAPDataHelper">Sync SAP Data Helper, <see cref="ISyncTM1DataHelper"/></param>
        /// <param name="sapHanaClient">Sync SAP Data Helper, <see cref="ISAPHanaClient"/></param>
        public MaterialGroupController(ILogger<MaterialGroupController> logger, IMediator mediator,
            ISyncSAPDataHelper syncSAPDataHelper, ISAPHanaClient sapHanaClient) : base(mediator, logger)
        {
            _logger = logger;
            _syncSAPDataHelper = syncSAPDataHelper;
            _sapHanaClient = sapHanaClient;
        }

        [HttpGet]
        [Route("SyncMaterialGroupFromSAP")]
        public async Task<bool> SyncMaterialGroupFromSAP()
        {
            try
            {
                var lastsyncMaterialGroupdate = _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_MaterialGroup);
                var sapMaterialGroups = await _sapHanaClient.GetMaterialGroupItems();
                return await _syncSAPDataHelper.SyncMaterialGroup(sapMaterialGroups);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in SyncMaterialGroupFromSAP");
                throw;
            }
        }

        [HttpGet]
        [Route("GetSAPLastSyncDate")]
        public DateTimeOffset GetSAPLastSyncDateAsync()
        {          
              return _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_MaterialGroup);
        }
    }
}
