/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormLPositionCommand.Add;
using QSS.eIQC.Handlers.Commands.FormLPositionCommand.Update;
using QSS.eIQC.Handlers.Commands.FormLPositionCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormLPositionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormLPosition Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormLPositionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormLPositionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormLPositionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormLPositionController(ILogger<FormLPositionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormLPosition configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormLPositionModel in a body, <see cref="AddFormLPositionModel"/></param>
        /// <returns>If success should return newly added FormLPositionModel <see cref="FormLPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormLPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormLPosition configuration
        /// </summary>
        /// <param name="id">FormLPosition Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormLPositionModel in a body, <see cref="UpdateFormLPositionModel"/></param>
        /// <returns>If success should return newly added FormLPositionModel <see cref="FormLPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormLPositionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormLPosition configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormLPositionModel in a body, <see cref="DeleteFormLPositionModel"/></param>
        /// <returns>If success should return newly added DeleteFormLPositionResponse <see cref="DeleteFormLPositionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormLPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}