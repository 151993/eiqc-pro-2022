/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PartCAFCommand.Add;
using QSS.eIQC.Handlers.Commands.PartCAFCommand.Update;
using QSS.eIQC.Handlers.Commands.PartCAFCommand.Delete;
using QSS.eIQC.Handlers.Commands.PartCAFCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartCAF Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PartCAFController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PartCAFController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PartCAFController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public PartCAFController(ILogger<PartCAFController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new PartCAF configuration
        /// </summary>
        /// <param name="request">Input parameter AddPartCAFModel in a body, <see cref="AddPartCAFModel"/></param>
        /// <returns>If success should return newly added PartCAFModel <see cref="PartCAFModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPartCAFCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPartCAFModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update PartCAF configuration
        /// </summary>
        /// <param name="id">PartCAF Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePartCAFModel in a body, <see cref="UpdatePartCAFModel"/></param>
        /// <returns>If success should return newly added PartCAFModel <see cref="PartCAFModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartCAFCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePartCAFModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete PartCAF configuration
        /// </summary>
        /// <param name="request">Input parameter DeletePartCAFModel in a body, <see cref="DeletePartCAFModel"/></param>
        /// <returns>If success should return newly added DeletePartCAFResponse <see cref="DeletePartCAFResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartCAFCanDelete))]
        public async Task<IActionResult> Delete(DeletePartCAFModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}