/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.InspectionCommand.Add;
using QSS.eIQC.Handlers.Commands.InspectionCommand.Update;
using QSS.eIQC.Handlers.Commands.InspectionCommand.Delete;
using QSS.eIQC.Handlers.Commands.InspectionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Inspection Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class InspectionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<InspectionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of InspectionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public InspectionController(ILogger<InspectionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Inspection configuration
        /// </summary>
        /// <param name="request">Input parameter AddInspectionModel in a body, <see cref="AddInspectionModel"/></param>
        /// <returns>If success should return newly added InspectionModel <see cref="InspectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminInspectionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddInspectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Inspection configuration
        /// </summary>
        /// <param name="id">Inspection Id as input in URL</param>
        /// <param name="request">Input parameter UpdateInspectionModel in a body, <see cref="UpdateInspectionModel"/></param>
        /// <returns>If success should return newly added InspectionModel <see cref="InspectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInspectionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInspectionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Inspection configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteInspectionModel in a body, <see cref="DeleteInspectionModel"/></param>
        /// <returns>If success should return newly added DeleteInspectionResponse <see cref="DeleteInspectionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInspectionCanDelete))]
        public async Task<IActionResult> Delete(DeleteInspectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}