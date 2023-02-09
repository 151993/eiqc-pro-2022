/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Add;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Update;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Delete;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartDateCode Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PartDateCodeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PartDateCodeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PartDateCodeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public PartDateCodeController(ILogger<PartDateCodeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new PartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter AddPartDateCodeModel in a body, <see cref="AddPartDateCodeModel"/></param>
        /// <returns>If success should return newly added PartDateCodeModel <see cref="PartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPartDateCodeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update PartDateCode configuration
        /// </summary>
        /// <param name="id">PartDateCode Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePartDateCodeModel in a body, <see cref="UpdatePartDateCodeModel"/></param>
        /// <returns>If success should return newly added PartDateCodeModel <see cref="PartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartDateCodeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePartDateCodeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete PartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter DeletePartDateCodeModel in a body, <see cref="DeletePartDateCodeModel"/></param>
        /// <returns>If success should return newly added DeletePartDateCodeResponse <see cref="DeletePartDateCodeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartDateCodeCanDelete))]
        public async Task<IActionResult> Delete(DeletePartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}