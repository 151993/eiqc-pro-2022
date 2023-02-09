/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormStatusCommand.Add;
using QSS.eIQC.Handlers.Commands.FormStatusCommand.Update;
using QSS.eIQC.Handlers.Commands.FormStatusCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormStatusCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormStatus Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormStatusController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormStatusController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormStatusController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormStatusController(ILogger<FormStatusController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormStatus configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormStatusModel in a body, <see cref="AddFormStatusModel"/></param>
        /// <returns>If success should return newly added FormStatusModel <see cref="FormStatusModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormStatusCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormStatusModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormStatus configuration
        /// </summary>
        /// <param name="id">FormStatus Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormStatusModel in a body, <see cref="UpdateFormStatusModel"/></param>
        /// <returns>If success should return newly added FormStatusModel <see cref="FormStatusModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormStatusCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormStatusModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormStatus configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormStatusModel in a body, <see cref="DeleteFormStatusModel"/></param>
        /// <returns>If success should return newly added DeleteFormStatusResponse <see cref="DeleteFormStatusResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormStatusCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormStatusModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}