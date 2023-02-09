/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormPackagingCommand.Add;
using QSS.eIQC.Handlers.Commands.FormPackagingCommand.Update;
using QSS.eIQC.Handlers.Commands.FormPackagingCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormPackagingCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormPackaging Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormPackagingController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormPackagingController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormPackagingController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormPackagingController(ILogger<FormPackagingController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormPackaging configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormPackagingModel in a body, <see cref="AddFormPackagingModel"/></param>
        /// <returns>If success should return newly added FormPackagingModel <see cref="FormPackagingModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormPackagingCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormPackagingModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormPackaging configuration
        /// </summary>
        /// <param name="id">FormPackaging Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormPackagingModel in a body, <see cref="UpdateFormPackagingModel"/></param>
        /// <returns>If success should return newly added FormPackagingModel <see cref="FormPackagingModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPackagingCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormPackagingModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormPackaging configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormPackagingModel in a body, <see cref="DeleteFormPackagingModel"/></param>
        /// <returns>If success should return newly added DeleteFormPackagingResponse <see cref="DeleteFormPackagingResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPackagingCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormPackagingModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}