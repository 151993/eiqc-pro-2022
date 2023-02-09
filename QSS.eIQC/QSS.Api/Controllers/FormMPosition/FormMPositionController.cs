/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMPositionCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMPositionCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMPositionCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMPositionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMPosition Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMPositionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMPositionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMPositionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMPositionController(ILogger<FormMPositionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMPosition configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMPositionModel in a body, <see cref="AddFormMPositionModel"/></param>
        /// <returns>If success should return newly added FormMPositionModel <see cref="FormMPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMPosition configuration
        /// </summary>
        /// <param name="id">FormMPosition Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMPositionModel in a body, <see cref="UpdateFormMPositionModel"/></param>
        /// <returns>If success should return newly added FormMPositionModel <see cref="FormMPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMPositionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMPosition configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMPositionModel in a body, <see cref="DeleteFormMPositionModel"/></param>
        /// <returns>If success should return newly added DeleteFormMPositionResponse <see cref="DeleteFormMPositionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}