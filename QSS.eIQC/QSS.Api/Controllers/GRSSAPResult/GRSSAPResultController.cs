/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Add;
using QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Update;
using QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Delete;
using QSS.eIQC.Handlers.Commands.GRSSAPResultCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// GRSSAPResult Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class GRSSAPResultController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<GRSSAPResultController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of GRSSAPResultController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public GRSSAPResultController(ILogger<GRSSAPResultController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new GRSSAPResult configuration
        /// </summary>
        /// <param name="request">Input parameter AddGRSSAPResultModel in a body, <see cref="AddGRSSAPResultModel"/></param>
        /// <returns>If success should return newly added GRSSAPResultModel <see cref="GRSSAPResultModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminGRSSAPResultCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddGRSSAPResultModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update GRSSAPResult configuration
        /// </summary>
        /// <param name="id">GRSSAPResult Id as input in URL</param>
        /// <param name="request">Input parameter UpdateGRSSAPResultModel in a body, <see cref="UpdateGRSSAPResultModel"/></param>
        /// <returns>If success should return newly added GRSSAPResultModel <see cref="GRSSAPResultModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSSAPResultCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGRSSAPResultModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete GRSSAPResult configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteGRSSAPResultModel in a body, <see cref="DeleteGRSSAPResultModel"/></param>
        /// <returns>If success should return newly added DeleteGRSSAPResultResponse <see cref="DeleteGRSSAPResultResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSSAPResultCanDelete))]
        public async Task<IActionResult> Delete(DeleteGRSSAPResultModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}