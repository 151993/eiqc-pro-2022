/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.GroupCommand.Add;
using QSS.eIQC.Handlers.Commands.GroupCommand.Update;
using QSS.eIQC.Handlers.Commands.GroupCommand.Delete;
using QSS.eIQC.Handlers.Commands.GroupCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Group Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<GroupController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of GroupController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public GroupController(ILogger<GroupController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Group configuration
        /// </summary>
        /// <param name="request">Input parameter AddGroupModel in a body, <see cref="AddGroupModel"/></param>
        /// <returns>If success should return newly added GroupModel <see cref="GroupModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminGroupCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddGroupModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Group configuration
        /// </summary>
        /// <param name="id">Group Id as input in URL</param>
        /// <param name="request">Input parameter UpdateGroupModel in a body, <see cref="UpdateGroupModel"/></param>
        /// <returns>If success should return newly added GroupModel <see cref="GroupModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGroupCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGroupModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Group configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteGroupModel in a body, <see cref="DeleteGroupModel"/></param>
        /// <returns>If success should return newly added DeleteGroupResponse <see cref="DeleteGroupResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGroupCanDelete))]
        public async Task<IActionResult> Delete(DeleteGroupModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}