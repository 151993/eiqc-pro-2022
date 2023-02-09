/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.CTParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.CTParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.CTParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.CTParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// CTParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CTParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CTParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CTParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public CTParameterController(ILogger<CTParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new CTParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddCTParameterModel in a body, <see cref="AddCTParameterModel"/></param>
        /// <returns>If success should return newly added CTParameterModel <see cref="CTParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCTParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCTParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update CTParameter configuration
        /// </summary>
        /// <param name="id">CTParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCTParameterModel in a body, <see cref="UpdateCTParameterModel"/></param>
        /// <returns>If success should return newly added CTParameterModel <see cref="CTParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCTParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCTParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete CTParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCTParameterModel in a body, <see cref="DeleteCTParameterModel"/></param>
        /// <returns>If success should return newly added DeleteCTParameterResponse <see cref="DeleteCTParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCTParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteCTParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}