/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Add;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Update;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Delete;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// InspectionTools Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class InspectionToolsController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<InspectionToolsController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of InspectionToolsController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public InspectionToolsController(ILogger<InspectionToolsController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new InspectionTools configuration
        /// </summary>
        /// <param name="request">Input parameter AddInspectionToolsModel in a body, <see cref="AddInspectionToolsModel"/></param>
        /// <returns>If success should return newly added InspectionToolsModel <see cref="InspectionToolsModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminInspectionToolsCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddInspectionToolsModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update InspectionTools configuration
        /// </summary>
        /// <param name="id">InspectionTools Id as input in URL</param>
        /// <param name="request">Input parameter UpdateInspectionToolsModel in a body, <see cref="UpdateInspectionToolsModel"/></param>
        /// <returns>If success should return newly added InspectionToolsModel <see cref="InspectionToolsModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInspectionToolsCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInspectionToolsModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete InspectionTools configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteInspectionToolsModel in a body, <see cref="DeleteInspectionToolsModel"/></param>
        /// <returns>If success should return newly added DeleteInspectionToolsResponse <see cref="DeleteInspectionToolsResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInspectionToolsCanDelete))]
        public async Task<IActionResult> Delete(DeleteInspectionToolsModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}