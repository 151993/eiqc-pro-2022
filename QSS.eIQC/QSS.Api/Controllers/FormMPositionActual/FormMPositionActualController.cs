/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMPositionActualCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMPositionActualCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMPositionActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMPositionActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMPositionActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMPositionActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMPositionActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMPositionActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMPositionActualController(ILogger<FormMPositionActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMPositionActualModel in a body, <see cref="AddFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added FormMPositionActualModel <see cref="FormMPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMPositionActual configuration
        /// </summary>
        /// <param name="id">FormMPositionActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMPositionActualModel in a body, <see cref="UpdateFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added FormMPositionActualModel <see cref="FormMPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMPositionActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMPositionActualModel in a body, <see cref="DeleteFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added DeleteFormMPositionActualResponse <see cref="DeleteFormMPositionActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMPositionActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}