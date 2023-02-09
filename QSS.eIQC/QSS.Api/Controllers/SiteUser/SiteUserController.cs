/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SiteUserCommand.Delete;
using QSS.eIQC.Handlers.Commands.SiteUserCommand.Update;
using QSS.eIQC.Handlers.Commands.SiteUserCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand.Add;

namespace QSS.Controllers
{
    /// <summary>
    /// SiteUser Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SiteUserController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SiteUserController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SiteUserController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public SiteUserController(ILogger<SiteUserController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new SiteUser configuration
        /// </summary>
        /// <param name="request">Input parameter AddSiteUserModel in a body, <see cref="AddSiteUserModel"/></param>
        /// <returns>If success should return newly added SiteUserModel <see cref="SiteUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSiteUserCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSiteUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SiteUser configuration
        /// </summary>
        /// <param name="id">SiteUser Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSiteUserModel in a body, <see cref="UpdateSiteUserModel"/></param>
        /// <returns>If success should return newly added SiteUserModel <see cref="SiteUserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSiteUserCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSiteUserModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SiteUser configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSiteUserModel in a body, <see cref="DeleteSiteUserModel"/></param>
        /// <returns>If success should return newly added DeleteSiteUserResponse <see cref="DeleteSiteUserResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSiteUserCanDelete))]
        public async Task<IActionResult> Delete(DeleteSiteUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
    }
}