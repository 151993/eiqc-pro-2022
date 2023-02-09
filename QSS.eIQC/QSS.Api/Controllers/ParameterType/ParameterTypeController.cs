/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Delete;
using QSS.eIQC.Handlers.Commands.ParameterTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ParameterType Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ParameterTypeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ParameterTypeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ParameterTypeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public ParameterTypeController(ILogger<ParameterTypeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new ParameterType configuration
        /// </summary>
        /// <param name="request">Input parameter AddParameterTypeModel in a body, <see cref="AddParameterTypeModel"/></param>
        /// <returns>If success should return newly added ParameterTypeModel <see cref="ParameterTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddParameterTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ParameterType configuration
        /// </summary>
        /// <param name="id">ParameterType Id as input in URL</param>
        /// <param name="request">Input parameter UpdateParameterTypeModel in a body, <see cref="UpdateParameterTypeModel"/></param>
        /// <returns>If success should return newly added ParameterTypeModel <see cref="ParameterTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateParameterTypeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ParameterType configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteParameterTypeModel in a body, <see cref="DeleteParameterTypeModel"/></param>
        /// <returns>If success should return newly added DeleteParameterTypeResponse <see cref="DeleteParameterTypeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCanDelete))]
        public async Task<IActionResult> Delete(DeleteParameterTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}