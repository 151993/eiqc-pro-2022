/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PartCommand.Add;
using QSS.eIQC.Handlers.Commands.PartCommand.Update;
using QSS.eIQC.Handlers.Commands.PartCommand.Delete;
using QSS.eIQC.Handlers.Commands.PartCommand;
using QSS.eIQC.SAPSync.Interface;
using QSS.eIQC.SAPHana.Services.Interface;
using System;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Part Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PartController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PartController> _logger;
        private IQSSGatewayAPIClient _qssClient;
        private readonly ISAPHanaClient _sapHanaClient;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;
        private readonly IPartRepository _partRepository;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PartController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public PartController(ILogger<PartController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient, ISyncSAPDataHelper syncSAPDataHelper, ISAPHanaClient sapHanaClient, IPartRepository partRepository) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
            _syncSAPDataHelper = syncSAPDataHelper;
            _sapHanaClient = sapHanaClient;
            _partRepository = partRepository;
        }

        /// <summary>
        /// Async POST Action method to Add new Part configuration
        /// </summary>
        /// <param name="request">Input parameter AddPartModel in a body, <see cref="AddPartModel"/></param>
        /// <returns>If success should return newly added PartModel <see cref="PartModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPartCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPartModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Part configuration
        /// </summary>
        /// <param name="id">Part Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePartModel in a body, <see cref="UpdatePartModel"/></param>
        /// <returns>If success should return newly added PartModel <see cref="PartModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePartModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }


        [HttpGet]
        [Route("SyncPartFromSAP")]
        public async Task<bool> SyncPartFromSAP()
        {
            try
            {
                var lastSyncPartDate = _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_Part);
                var sapParts = await _sapHanaClient.GetParts();
                return await _syncSAPDataHelper.SyncPart(sapParts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in SyncPartFromSAP");
                throw;
            }
        }

        [HttpGet]
        [Route("GetSAPLastSyncDate")]
        public DateTimeOffset GetSAPLastSyncDateAsync()
        {
            return _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_Part);
        }

        [HttpGet("GetCAFNoPrefix")]
        public async Task<string> GetCAFNoPrefix(int siteId, int workCellId)
        {
            return await _partRepository.GetCAFNoPrefix(siteId, workCellId);
        }
    }
}