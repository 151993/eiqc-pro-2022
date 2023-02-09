/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Add;
using QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Update;
using QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Delete;
using QSS.eIQC.Handlers.Commands.CompletedGRSCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// CompletedGRS Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CompletedGRSController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CompletedGRSController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CompletedGRSController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public CompletedGRSController(ILogger<CompletedGRSController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new CompletedGRS configuration
        /// </summary>
        /// <param name="request">Input parameter AddCompletedGRSModel in a body, <see cref="AddCompletedGRSModel"/></param>
        /// <returns>If success should return newly added CompletedGRSModel <see cref="CompletedGRSModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCompletedGRSCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCompletedGRSModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update CompletedGRS configuration
        /// </summary>
        /// <param name="id">CompletedGRS Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCompletedGRSModel in a body, <see cref="UpdateCompletedGRSModel"/></param>
        /// <returns>If success should return newly added CompletedGRSModel <see cref="CompletedGRSModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCompletedGRSCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCompletedGRSModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete CompletedGRS configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCompletedGRSModel in a body, <see cref="DeleteCompletedGRSModel"/></param>
        /// <returns>If success should return newly added DeleteCompletedGRSResponse <see cref="DeleteCompletedGRSResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCompletedGRSCanDelete))]
        public async Task<IActionResult> Delete(DeleteCompletedGRSModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}