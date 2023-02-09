/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Add;
using QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Update;
using QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormLPositionActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormLPositionActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormLPositionActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormLPositionActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormLPositionActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormLPositionActualController(ILogger<FormLPositionActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormLPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormLPositionActualModel in a body, <see cref="AddFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added FormLPositionActualModel <see cref="FormLPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormLPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormLPositionActual configuration
        /// </summary>
        /// <param name="id">FormLPositionActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormLPositionActualModel in a body, <see cref="UpdateFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added FormLPositionActualModel <see cref="FormLPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormLPositionActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormLPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormLPositionActualModel in a body, <see cref="DeleteFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added DeleteFormLPositionActualResponse <see cref="DeleteFormLPositionActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormLPositionActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormLPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}