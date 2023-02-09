/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMeasurementParameterActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMeasurementParameterActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMeasurementParameterActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMeasurementParameterActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMeasurementParameterActualController(ILogger<FormMeasurementParameterActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMeasurementParameterActualModel in a body, <see cref="AddFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added FormMeasurementParameterActualModel <see cref="FormMeasurementParameterActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMeasurementParameterActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="id">FormMeasurementParameterActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMeasurementParameterActualModel in a body, <see cref="UpdateFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added FormMeasurementParameterActualModel <see cref="FormMeasurementParameterActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMeasurementParameterActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMeasurementParameterActualModel in a body, <see cref="DeleteFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added DeleteFormMeasurementParameterActualResponse <see cref="DeleteFormMeasurementParameterActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMeasurementParameterActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}