/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.UOMCommand.Add;
using QSS.eIQC.Handlers.Commands.UOMCommand.Update;
using QSS.eIQC.Handlers.Commands.UOMCommand.Delete;
using QSS.eIQC.Handlers.Commands.UOMCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// UOM Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class UOMController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<UOMController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of UOMController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public UOMController(ILogger<UOMController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new UOM configuration
        /// </summary>
        /// <param name="request">Input parameter AddUOMModel in a body, <see cref="AddUOMModel"/></param>
        /// <returns>If success should return newly added UOMModel <see cref="UOMModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminUOMCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddUOMModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update UOM configuration
        /// </summary>
        /// <param name="id">UOM Id as input in URL</param>
        /// <param name="request">Input parameter UpdateUOMModel in a body, <see cref="UpdateUOMModel"/></param>
        /// <returns>If success should return newly added UOMModel <see cref="UOMModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminUOMCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUOMModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete UOM configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteUOMModel in a body, <see cref="DeleteUOMModel"/></param>
        /// <returns>If success should return newly added DeleteUOMResponse <see cref="DeleteUOMResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminUOMCanDelete))]
        public async Task<IActionResult> Delete(DeleteUOMModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}