/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Update;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Delete;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ParameterManagement Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ParameterManagementController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ParameterManagementController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ParameterManagementController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public ParameterManagementController(ILogger<ParameterManagementController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new ParameterManagement configuration
        /// </summary>
        /// <param name="request">Input parameter AddParameterManagementModel in a body, <see cref="AddParameterManagementModel"/></param>
        /// <returns>If success should return newly added ParameterManagementModel <see cref="ParameterManagementModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminParameterManagementCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddParameterManagementModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ParameterManagement configuration
        /// </summary>
        /// <param name="id">ParameterManagement Id as input in URL</param>
        /// <param name="request">Input parameter UpdateParameterManagementModel in a body, <see cref="UpdateParameterManagementModel"/></param>
        /// <returns>If success should return newly added ParameterManagementModel <see cref="ParameterManagementModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterManagementCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateParameterManagementModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ParameterManagement configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteParameterManagementModel in a body, <see cref="DeleteParameterManagementModel"/></param>
        /// <returns>If success should return newly added DeleteParameterManagementResponse <see cref="DeleteParameterManagementResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterManagementCanDelete))]
        public async Task<IActionResult> Delete(DeleteParameterManagementModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}