/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.GRSCommand.Add;
using QSS.eIQC.Handlers.Commands.GRSCommand.Update;
using QSS.eIQC.Handlers.Commands.GRSCommand.Delete;
using QSS.eIQC.Handlers.Commands.GRSCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// GRS Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class GRSController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<GRSController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of GRSController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public GRSController(ILogger<GRSController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new GRS configuration
        /// </summary>
        /// <param name="request">Input parameter AddGRSModel in a body, <see cref="AddGRSModel"/></param>
        /// <returns>If success should return newly added GRSModel <see cref="GRSModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminGRSCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddGRSModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update GRS configuration
        /// </summary>
        /// <param name="id">GRS Id as input in URL</param>
        /// <param name="request">Input parameter UpdateGRSModel in a body, <see cref="UpdateGRSModel"/></param>
        /// <returns>If success should return newly added GRSModel <see cref="GRSModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGRSModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete GRS configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteGRSModel in a body, <see cref="DeleteGRSModel"/></param>
        /// <returns>If success should return newly added DeleteGRSResponse <see cref="DeleteGRSResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSCanDelete))]
        public async Task<IActionResult> Delete(DeleteGRSModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}