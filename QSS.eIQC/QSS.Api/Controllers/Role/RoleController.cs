using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.Handlers.Commands.RoleCommand.Delete;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using QSS.Helpers.Http;
using System.Threading.Tasks;

namespace QSS.Controllers
{
    /// <summary>
    /// Role Controller provides Add, Update and Delete operations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
	
    public class RoleController : BaseController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of RoleController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public RoleController(ILogger<RoleController> logger, IMediator mediator) : base(mediator, logger)
        {

        }

        /// <summary>
        /// Async POST Action method to Add new Role configuration
        /// </summary>
        /// <param name="request">Input parameter AddRoleModel in a body, <see cref="AddRoleModel"/></param>
        /// <returns>If success should return newly added RoleModel <see cref="RoleModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminRoleCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddRoleModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Role configuration
        /// </summary>
        /// <param name="id">Role Id as input in URL</param>
        /// <param name="request">Input parameter UpdateRoleModel in a body, <see cref="UpdateRoleModel"/></param>
        /// <returns>If success should return newly added RoleModel <see cref="RoleModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Authorize(policy: nameof(PermissionType.AdminRoleCanUpdate))]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRoleModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Role configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteRoleModel in a body, <see cref="DeleteRoleModel"/></param>
        /// <returns>If success should return newly added DeleteRoleResponse <see cref="DeleteRoleResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Authorize(policy: nameof(PermissionType.AdminRoleCanDelete))]
        [Route("{id}")]
        public async Task<IActionResult> Delete(DeleteRoleModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
    }
}

