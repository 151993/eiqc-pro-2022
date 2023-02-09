/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Add;
using QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Update;
using QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Delete;
using QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// GoodsReceiveUser Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class GoodsReceiveUserController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<GoodsReceiveUserController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of GoodsReceiveUserController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public GoodsReceiveUserController(ILogger<GoodsReceiveUserController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new GoodsReceiveUser configuration
        /// </summary>
        /// <param name="request">Input parameter AddGoodsReceiveUserModel in a body, <see cref="AddGoodsReceiveUserModel"/></param>
        /// <returns>If success should return newly added GoodsReceiveUserModel <see cref="GoodsReceiveUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminGoodsReceiveUserCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddGoodsReceiveUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update GoodsReceiveUser configuration
        /// </summary>
        /// <param name="id">GoodsReceiveUser Id as input in URL</param>
        /// <param name="request">Input parameter UpdateGoodsReceiveUserModel in a body, <see cref="UpdateGoodsReceiveUserModel"/></param>
        /// <returns>If success should return newly added GoodsReceiveUserModel <see cref="GoodsReceiveUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGoodsReceiveUserCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGoodsReceiveUserModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete GoodsReceiveUser configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteGoodsReceiveUserModel in a body, <see cref="DeleteGoodsReceiveUserModel"/></param>
        /// <returns>If success should return newly added DeleteGoodsReceiveUserResponse <see cref="DeleteGoodsReceiveUserResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGoodsReceiveUserCanDelete))]
        public async Task<IActionResult> Delete(DeleteGoodsReceiveUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}