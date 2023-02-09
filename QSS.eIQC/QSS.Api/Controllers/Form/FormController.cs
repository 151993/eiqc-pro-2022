/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormCommand.Add;
using QSS.eIQC.Handlers.Commands.FormCommand.Update;
using QSS.eIQC.Handlers.Commands.FormCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Form Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormController(ILogger<FormController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Form configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormModel in a body, <see cref="AddFormModel"/></param>
        /// <returns>If success should return newly added FormModel <see cref="FormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Form configuration
        /// </summary>
        /// <param name="id">Form Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormModel in a body, <see cref="UpdateFormModel"/></param>
        /// <returns>If success should return newly added FormModel <see cref="FormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Form configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormModel in a body, <see cref="DeleteFormModel"/></param>
        /// <returns>If success should return newly added DeleteFormResponse <see cref="DeleteFormResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}