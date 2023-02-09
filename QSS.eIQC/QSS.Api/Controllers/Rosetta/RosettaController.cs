/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.RosettaCommand.Add;
using QSS.eIQC.Handlers.Commands.RosettaCommand.Update;
using QSS.eIQC.Handlers.Commands.RosettaCommand.Delete;
using QSS.eIQC.Handlers.Commands.RosettaCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Rosetta Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class RosettaController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<RosettaController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of RosettaController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public RosettaController(ILogger<RosettaController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Rosetta configuration
        /// </summary>
        /// <param name="request">Input parameter AddRosettaModel in a body, <see cref="AddRosettaModel"/></param>
        /// <returns>If success should return newly added RosettaModel <see cref="RosettaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminRosettaCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddRosettaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Rosetta configuration
        /// </summary>
        /// <param name="id">Rosetta Id as input in URL</param>
        /// <param name="request">Input parameter UpdateRosettaModel in a body, <see cref="UpdateRosettaModel"/></param>
        /// <returns>If success should return newly added RosettaModel <see cref="RosettaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminRosettaCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRosettaModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Rosetta configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteRosettaModel in a body, <see cref="DeleteRosettaModel"/></param>
        /// <returns>If success should return newly added DeleteRosettaResponse <see cref="DeleteRosettaResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminRosettaCanDelete))]
        public async Task<IActionResult> Delete(DeleteRosettaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}