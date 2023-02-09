/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMeasurementParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMeasurementParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMeasurementParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMeasurementParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMeasurementParameterController(ILogger<FormMeasurementParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMeasurementParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMeasurementParameterModel in a body, <see cref="AddFormMeasurementParameterModel"/></param>
        /// <returns>If success should return newly added FormMeasurementParameterModel <see cref="FormMeasurementParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMeasurementParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMeasurementParameter configuration
        /// </summary>
        /// <param name="id">FormMeasurementParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMeasurementParameterModel in a body, <see cref="UpdateFormMeasurementParameterModel"/></param>
        /// <returns>If success should return newly added FormMeasurementParameterModel <see cref="FormMeasurementParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMeasurementParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMeasurementParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMeasurementParameterModel in a body, <see cref="DeleteFormMeasurementParameterModel"/></param>
        /// <returns>If success should return newly added DeleteFormMeasurementParameterResponse <see cref="DeleteFormMeasurementParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMeasurementParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMeasurementParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}