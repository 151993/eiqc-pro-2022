/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.FormSAPParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormSAPParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormSAPParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormSAPParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormSAPParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormSAPParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormSAPParameterController(ILogger<FormSAPParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormSAPParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormSAPParameterModel in a body, <see cref="AddFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added FormSAPParameterModel <see cref="FormSAPParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormSAPParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormSAPParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormSAPParameter configuration
        /// </summary>
        /// <param name="id">FormSAPParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormSAPParameterModel in a body, <see cref="UpdateFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added FormSAPParameterModel <see cref="FormSAPParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormSAPParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormSAPParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormSAPParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormSAPParameterModel in a body, <see cref="DeleteFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added DeleteFormSAPParameterResponse <see cref="DeleteFormSAPParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormSAPParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormSAPParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}