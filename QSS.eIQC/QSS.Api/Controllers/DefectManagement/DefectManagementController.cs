/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand.Add;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand.Update;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand.Delete;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DefectManagement Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class DefectManagementController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<DefectManagementController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DefectManagementController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public DefectManagementController(ILogger<DefectManagementController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new DefectManagement configuration
        /// </summary>
        /// <param name="request">Input parameter AddDefectManagementModel in a body, <see cref="AddDefectManagementModel"/></param>
        /// <returns>If success should return newly added DefectManagementModel <see cref="DefectManagementModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminDefectManagementCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddDefectManagementModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update DefectManagement configuration
        /// </summary>
        /// <param name="id">DefectManagement Id as input in URL</param>
        /// <param name="request">Input parameter UpdateDefectManagementModel in a body, <see cref="UpdateDefectManagementModel"/></param>
        /// <returns>If success should return newly added DefectManagementModel <see cref="DefectManagementModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDefectManagementCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDefectManagementModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete DefectManagement configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteDefectManagementModel in a body, <see cref="DeleteDefectManagementModel"/></param>
        /// <returns>If success should return newly added DeleteDefectManagementResponse <see cref="DeleteDefectManagementResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDefectManagementCanDelete))]
        public async Task<IActionResult> Delete(DeleteDefectManagementModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}