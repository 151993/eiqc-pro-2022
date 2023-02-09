/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormResultOrientedParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormResultOrientedParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormResultOrientedParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormResultOrientedParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormResultOrientedParameterController(ILogger<FormResultOrientedParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormResultOrientedParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormResultOrientedParameterModel in a body, <see cref="AddFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added FormResultOrientedParameterModel <see cref="FormResultOrientedParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormResultOrientedParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormResultOrientedParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormResultOrientedParameter configuration
        /// </summary>
        /// <param name="id">FormResultOrientedParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormResultOrientedParameterModel in a body, <see cref="UpdateFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added FormResultOrientedParameterModel <see cref="FormResultOrientedParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormResultOrientedParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormResultOrientedParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormResultOrientedParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormResultOrientedParameterModel in a body, <see cref="DeleteFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added DeleteFormResultOrientedParameterResponse <see cref="DeleteFormResultOrientedParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormResultOrientedParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormResultOrientedParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}