/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Add;
using QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Update;
using QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormFunParaActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormFunParaActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormFunParaActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormFunParaActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormFunParaActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormFunParaActualController(ILogger<FormFunParaActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormFunParaActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormFunParaActualModel in a body, <see cref="AddFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added FormFunParaActualModel <see cref="FormFunParaActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormFunParaActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormFunParaActual configuration
        /// </summary>
        /// <param name="id">FormFunParaActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormFunParaActualModel in a body, <see cref="UpdateFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added FormFunParaActualModel <see cref="FormFunParaActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormFunParaActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormFunParaActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormFunParaActualModel in a body, <see cref="DeleteFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added DeleteFormFunParaActualResponse <see cref="DeleteFormFunParaActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormFunParaActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}