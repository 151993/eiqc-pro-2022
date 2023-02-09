/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormCountParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormCountParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormCountParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormCountParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormCountParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormCountParameterController(ILogger<FormCountParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormCountParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormCountParameterModel in a body, <see cref="AddFormCountParameterModel"/></param>
        /// <returns>If success should return newly added FormCountParameterModel <see cref="FormCountParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormCountParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormCountParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormCountParameter configuration
        /// </summary>
        /// <param name="id">FormCountParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormCountParameterModel in a body, <see cref="UpdateFormCountParameterModel"/></param>
        /// <returns>If success should return newly added FormCountParameterModel <see cref="FormCountParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormCountParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormCountParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormCountParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormCountParameterModel in a body, <see cref="DeleteFormCountParameterModel"/></param>
        /// <returns>If success should return newly added DeleteFormCountParameterResponse <see cref="DeleteFormCountParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormCountParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormCountParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}