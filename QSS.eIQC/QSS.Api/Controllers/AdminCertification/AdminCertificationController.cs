/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Add;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Update;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Delete;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// AdminCertification Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class AdminCertificationController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<AdminCertificationController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of AdminCertificationController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public AdminCertificationController(ILogger<AdminCertificationController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new AdminCertification configuration
        /// </summary>
        /// <param name="request">Input parameter AddAdminCertificationModel in a body, <see cref="AddAdminCertificationModel"/></param>
        /// <returns>If success should return newly added AdminCertificationModel <see cref="AdminCertificationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCertificationCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddAdminCertificationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update AdminCertification configuration
        /// </summary>
        /// <param name="id">AdminCertification Id as input in URL</param>
        /// <param name="request">Input parameter UpdateAdminCertificationModel in a body, <see cref="UpdateAdminCertificationModel"/></param>
        /// <returns>If success should return newly added AdminCertificationModel <see cref="AdminCertificationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCertificationCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAdminCertificationModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete AdminCertification configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteAdminCertificationModel in a body, <see cref="DeleteAdminCertificationModel"/></param>
        /// <returns>If success should return newly added DeleteAdminCertificationResponse <see cref="DeleteAdminCertificationResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCertificationCanDelete))]
        public async Task<IActionResult> Delete(DeleteAdminCertificationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}