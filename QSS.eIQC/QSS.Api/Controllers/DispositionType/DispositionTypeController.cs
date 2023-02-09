/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Delete;
using QSS.eIQC.Handlers.Commands.DispositionTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DispositionType Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class DispositionTypeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<DispositionTypeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DispositionTypeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public DispositionTypeController(ILogger<DispositionTypeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new DispositionType configuration
        /// </summary>
        /// <param name="request">Input parameter AddDispositionTypeModel in a body, <see cref="AddDispositionTypeModel"/></param>
        /// <returns>If success should return newly added DispositionTypeModel <see cref="DispositionTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminDispositionTypeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddDispositionTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update DispositionType configuration
        /// </summary>
        /// <param name="id">DispositionType Id as input in URL</param>
        /// <param name="request">Input parameter UpdateDispositionTypeModel in a body, <see cref="UpdateDispositionTypeModel"/></param>
        /// <returns>If success should return newly added DispositionTypeModel <see cref="DispositionTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDispositionTypeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDispositionTypeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete DispositionType configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteDispositionTypeModel in a body, <see cref="DeleteDispositionTypeModel"/></param>
        /// <returns>If success should return newly added DeleteDispositionTypeResponse <see cref="DeleteDispositionTypeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDispositionTypeCanDelete))]
        public async Task<IActionResult> Delete(DeleteDispositionTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}