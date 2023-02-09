/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Add;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Update;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Delete;
using QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ReceiveGoodsInfo Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveGoodsInfoController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ReceiveGoodsInfoController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ReceiveGoodsInfoController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public ReceiveGoodsInfoController(ILogger<ReceiveGoodsInfoController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new ReceiveGoodsInfo configuration
        /// </summary>
        /// <param name="request">Input parameter AddReceiveGoodsInfoModel in a body, <see cref="AddReceiveGoodsInfoModel"/></param>
        /// <returns>If success should return newly added ReceiveGoodsInfoModel <see cref="ReceiveGoodsInfoModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddReceiveGoodsInfoModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ReceiveGoodsInfo configuration
        /// </summary>
        /// <param name="id">ReceiveGoodsInfo Id as input in URL</param>
        /// <param name="request">Input parameter UpdateReceiveGoodsInfoModel in a body, <see cref="UpdateReceiveGoodsInfoModel"/></param>
        /// <returns>If success should return newly added ReceiveGoodsInfoModel <see cref="ReceiveGoodsInfoModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateReceiveGoodsInfoModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ReceiveGoodsInfo configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteReceiveGoodsInfoModel in a body, <see cref="DeleteReceiveGoodsInfoModel"/></param>
        /// <returns>If success should return newly added DeleteReceiveGoodsInfoResponse <see cref="DeleteReceiveGoodsInfoResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminReceiveGoodsInfoCanDelete))]
        public async Task<IActionResult> Delete(DeleteReceiveGoodsInfoModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}