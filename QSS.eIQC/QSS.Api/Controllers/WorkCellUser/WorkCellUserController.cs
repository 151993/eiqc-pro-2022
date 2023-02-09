/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Add;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Update;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Delete;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// WorkCellUser Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class WorkCellUserController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<WorkCellUserController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of WorkCellUserController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public WorkCellUserController(ILogger<WorkCellUserController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new WorkCellUser configuration
        /// </summary>
        /// <param name="request">Input parameter AddWorkCellUserModel in a body, <see cref="AddWorkCellUserModel"/></param>
        /// <returns>If success should return newly added WorkCellUserModel <see cref="WorkCellUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellUserCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddWorkCellUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update WorkCellUser configuration
        /// </summary>
        /// <param name="id">WorkCellUser Id as input in URL</param>
        /// <param name="request">Input parameter UpdateWorkCellUserModel in a body, <see cref="UpdateWorkCellUserModel"/></param>
        /// <returns>If success should return newly added WorkCellUserModel <see cref="WorkCellUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellUserCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateWorkCellUserModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete WorkCellUser configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteWorkCellUserModel in a body, <see cref="DeleteWorkCellUserModel"/></param>
        /// <returns>If success should return newly added DeleteWorkCellUserResponse <see cref="DeleteWorkCellUserResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellUserCanDelete))]
        public async Task<IActionResult> Delete(DeleteWorkCellUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}