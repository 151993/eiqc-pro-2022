/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SiteCommand.Add;
using QSS.eIQC.Handlers.Commands.SiteCommand.Update;
using QSS.eIQC.Handlers.Commands.SiteCommand.Delete;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.TM1Sync.Interface;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System;

namespace QSS.Controllers
{
    /// <summary>
    /// Site Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SiteController> _logger;
        private IQSSGatewayAPIClient _qssClient;
        private readonly ISyncTM1DataHelper _syncTM1DataHelper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SiteController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="syncTM1DataHelper">Sync TM1 Data Helper</param>
        public SiteController(ILogger<SiteController> logger, IMediator mediator, ISyncTM1DataHelper syncTM1DataHelper, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
            _syncTM1DataHelper = syncTM1DataHelper;
        }

        /// <summary>
        /// Async POST Action method to Add new Site configuration
        /// </summary>
        /// <param name="request">Input parameter AddSiteModel in a body, <see cref="AddSiteModel"/></param>
        /// <returns>If success should return newly added SiteModel <see cref="SiteModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSiteCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSiteModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Site configuration
        /// </summary>
        /// <param name="id">Site Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSiteModel in a body, <see cref="UpdateSiteModel"/></param>
        /// <returns>If success should return newly added SiteModel <see cref="SiteModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSiteCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSiteModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Site configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSiteModel in a body, <see cref="DeleteSiteModel"/></param>
        /// <returns>If success should return newly added DeleteSiteResponse <see cref="DeleteSiteResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSiteCanDelete))]
        public async Task<IActionResult> Delete(DeleteSiteModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        [HttpGet]
        [Route("SyncSiteFromTM1")]
        public async Task<bool> SyncSiteFromTM1()
        {
            try
            {
                var lastSyncSitedate = _syncTM1DataHelper.GetTM1LastSyncDate(SyncTM1DataType.Last_Sync_Site);
                var tM1Sites = await _qssClient.GetSite(lastSyncSitedate);
                return await _syncTM1DataHelper.SyncSite(tM1Sites);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in SyncSiteFromTM1");
                throw;
            }
        }

        [HttpGet]
        [Route("GetTM1LastSyncDate")]
        public DateTimeOffset GetTM1LastSyncDateAsync()
        {
            return _syncTM1DataHelper.GetTM1LastSyncDate(SyncTM1DataType.Last_Sync_Site);
        }
    }
}