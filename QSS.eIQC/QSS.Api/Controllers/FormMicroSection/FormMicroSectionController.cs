/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Add;
using QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Update;
using QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormMicroSectionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormMicroSection Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormMicroSectionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormMicroSectionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormMicroSectionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormMicroSectionController(ILogger<FormMicroSectionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormMicroSection configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormMicroSectionModel in a body, <see cref="AddFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added FormMicroSectionModel <see cref="FormMicroSectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormMicroSectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormMicroSection configuration
        /// </summary>
        /// <param name="id">FormMicroSection Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormMicroSectionModel in a body, <see cref="UpdateFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added FormMicroSectionModel <see cref="FormMicroSectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormMicroSectionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormMicroSection configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormMicroSectionModel in a body, <see cref="DeleteFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added DeleteFormMicroSectionResponse <see cref="DeleteFormMicroSectionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormMicroSectionCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormMicroSectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}