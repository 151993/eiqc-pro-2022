/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Add;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Update;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Delete;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ReceiveGoodsInfoManual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveGoodsInfoManualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ReceiveGoodsInfoManualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ReceiveGoodsInfoManualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public ReceiveGoodsInfoManualController(ILogger<ReceiveGoodsInfoManualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new ReceiveGoodsInfoManual configuration
        /// </summary>
        /// <param name="request">Input parameter AddReceiveGoodsInfoManualModel in a body, <see cref="AddReceiveGoodsInfoManualModel"/></param>
        /// <returns>If success should return newly added ReceiveGoodsInfoManualModel <see cref="ReceiveGoodsInfoManualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoManualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddReceiveGoodsInfoManualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ReceiveGoodsInfoManual configuration
        /// </summary>
        /// <param name="id">ReceiveGoodsInfoManual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateReceiveGoodsInfoManualModel in a body, <see cref="UpdateReceiveGoodsInfoManualModel"/></param>
        /// <returns>If success should return newly added ReceiveGoodsInfoManualModel <see cref="ReceiveGoodsInfoManualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoManualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateReceiveGoodsInfoManualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ReceiveGoodsInfoManual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteReceiveGoodsInfoManualModel in a body, <see cref="DeleteReceiveGoodsInfoManualModel"/></param>
        /// <returns>If success should return newly added DeleteReceiveGoodsInfoManualResponse <see cref="DeleteReceiveGoodsInfoManualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoManualCanDelete))]
        public async Task<IActionResult> Delete(DeleteReceiveGoodsInfoManualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}