/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Add;
using QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Update;
using QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormPartDateCode Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormPartDateCodeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormPartDateCodeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormPartDateCodeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormPartDateCodeController(ILogger<FormPartDateCodeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormPartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormPartDateCodeModel in a body, <see cref="AddFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added FormPartDateCodeModel <see cref="FormPartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormPartDateCodeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormPartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormPartDateCode configuration
        /// </summary>
        /// <param name="id">FormPartDateCode Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormPartDateCodeModel in a body, <see cref="UpdateFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added FormPartDateCodeModel <see cref="FormPartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPartDateCodeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormPartDateCodeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormPartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormPartDateCodeModel in a body, <see cref="DeleteFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added DeleteFormPartDateCodeResponse <see cref="DeleteFormPartDateCodeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPartDateCodeCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormPartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}