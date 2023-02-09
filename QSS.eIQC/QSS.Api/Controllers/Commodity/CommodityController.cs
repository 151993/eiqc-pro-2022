using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.CommodityCommand.Add;
using QSS.eIQC.Handlers.Commands.CommodityCommand.Delete;
using QSS.eIQC.Handlers.Commands.CommodityCommand.Update;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPSync.Interface;
using QSS.Helpers.Http;

namespace QSS.eIQC.Api.Controllers.Commodity
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommodityController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CommodityController> _logger;
        private readonly ISAPHanaClient _sapHanaClient;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of MaterialGroupController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public CommodityController(ILogger<CommodityController> logger, IMediator mediator,
            ISyncSAPDataHelper syncSAPDataHelper, ISAPHanaClient sapHanaClient) : base(mediator, logger)
        {
            _logger = logger;
            _syncSAPDataHelper = syncSAPDataHelper;
            _sapHanaClient = sapHanaClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Material Group configuration
        /// </summary>
        /// <param name="request">Input parameter AddMaterialGroupModel in a body, <see cref="AddCommodityModel"/></param>
        /// <returns>If success should return newly added AddMaterialGroupModel <see cref="AddCommodityModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCommodityModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update User configuration
        /// </summary>
        /// <param name="id">Material Group Id as input in URL</param>
        /// <param name="request">Input parameter UpdateMaterialGroupModel in a body, <see cref="UpdateCommodityModel"/></param>
        /// <returns>If success should return newly added UpdateMaterialGroupModel <see cref="UpdateCommodityModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCommodityModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Commodity configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCommodityModel in a body, <see cref="DeleteCommodityModel"/></param>
        /// <returns>If success should return newly added DeleteCommodityResponse <see cref="DeleteCommodityResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCanDelete))]
        public async Task<IActionResult> Delete(DeleteCommodityModel request)
        {
            return await ExecuteMediatrRequest(request);
        }


        [HttpGet]
        [Route("SyncCommodityFromSAP")]
        public async Task<bool> SyncCommodityFromSAP()
        {
            try
            {
                var lastsyncMaterialGroupdate = _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_Commodity);
                var sapCommodity = await _sapHanaClient.GetCommodities();
                return await _syncSAPDataHelper.SyncCommodity(sapCommodity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in SyncCommodityFromSAP");
                throw;
            }
        }

        [HttpGet]
        [Route("GetSAPLastSyncDate")]
        public dynamic GetSAPLastSyncDateAsync()
        {
            return _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_Commodity);
        }
    }
}
