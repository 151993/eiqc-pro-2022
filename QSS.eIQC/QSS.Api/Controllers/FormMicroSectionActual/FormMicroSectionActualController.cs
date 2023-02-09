/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMicroSectionActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMicroSectionActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMicroSectionActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMicroSectionActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMicroSectionActualController(ILogger<FormMicroSectionActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMicroSectionActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMicroSectionActualModel in a body, <see cref="AddFormMicroSectionActualModel"/></param>
        /// <returns>If success should return newly added FormMicroSectionActualModel <see cref="FormMicroSectionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMicroSectionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMicroSectionActual configuration
        /// </summary>
        /// <param name="id">FormMicroSectionActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMicroSectionActualModel in a body, <see cref="UpdateFormMicroSectionActualModel"/></param>
        /// <returns>If success should return newly added FormMicroSectionActualModel <see cref="FormMicroSectionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMicroSectionActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMicroSectionActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMicroSectionActualModel in a body, <see cref="DeleteFormMicroSectionActualModel"/></param>
        /// <returns>If success should return newly added DeleteFormMicroSectionActualResponse <see cref="DeleteFormMicroSectionActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMicroSectionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}