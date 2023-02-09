/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Update;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Delete;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DCCConfiguration Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class DCCConfigurationController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<DCCConfigurationController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DCCConfigurationController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public DCCConfigurationController(ILogger<DCCConfigurationController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new DCCConfiguration configuration
        /// </summary>
        /// <param name="request">Input parameter AddDCCConfigurationModel in a body, <see cref="AddDCCConfigurationModel"/></param>
        /// <returns>If success should return newly added DCCConfigurationModel <see cref="DCCConfigurationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminDCCConfigurationCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddDCCConfigurationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update DCCConfiguration configuration
        /// </summary>
        /// <param name="id">DCCConfiguration Id as input in URL</param>
        /// <param name="request">Input parameter UpdateDCCConfigurationModel in a body, <see cref="UpdateDCCConfigurationModel"/></param>
        /// <returns>If success should return newly added DCCConfigurationModel <see cref="DCCConfigurationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDCCConfigurationCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDCCConfigurationModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete DCCConfiguration configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteDCCConfigurationModel in a body, <see cref="DeleteDCCConfigurationModel"/></param>
        /// <returns>If success should return newly added DeleteDCCConfigurationResponse <see cref="DeleteDCCConfigurationResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDCCConfigurationCanDelete))]
        public async Task<IActionResult> Delete(DeleteDCCConfigurationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}