/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Delete;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PCCodeInspectionToolsType Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PCCodeInspectionToolsTypeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PCCodeInspectionToolsTypeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PCCodeInspectionToolsTypeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public PCCodeInspectionToolsTypeController(ILogger<PCCodeInspectionToolsTypeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new PCCodeInspectionToolsType configuration
        /// </summary>
        /// <param name="request">Input parameter AddPCCodeInspectionToolsTypeModel in a body, <see cref="AddPCCodeInspectionToolsTypeModel"/></param>
        /// <returns>If success should return newly added PCCodeInspectionToolsTypeModel <see cref="PCCodeInspectionToolsTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPCCodeInspectionToolsTypeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPCCodeInspectionToolsTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update PCCodeInspectionToolsType configuration
        /// </summary>
        /// <param name="id">PCCodeInspectionToolsType Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePCCodeInspectionToolsTypeModel in a body, <see cref="UpdatePCCodeInspectionToolsTypeModel"/></param>
        /// <returns>If success should return newly added PCCodeInspectionToolsTypeModel <see cref="PCCodeInspectionToolsTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPCCodeInspectionToolsTypeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePCCodeInspectionToolsTypeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete PCCodeInspectionToolsType configuration
        /// </summary>
        /// <param name="request">Input parameter DeletePCCodeInspectionToolsTypeModel in a body, <see cref="DeletePCCodeInspectionToolsTypeModel"/></param>
        /// <returns>If success should return newly added DeletePCCodeInspectionToolsTypeResponse <see cref="DeletePCCodeInspectionToolsTypeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPCCodeInspectionToolsTypeCanDelete))]
        public async Task<IActionResult> Delete(DeletePCCodeInspectionToolsTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}