
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Update;
using QSS.Helpers.Http;

namespace QSS.eIQC.Api.Controllers.WorkCell
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkCellController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<WorkCellController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of WorkCellController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public WorkCellController(ILogger<WorkCellController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new workcell configuration
        /// </summary>
        /// <param name="request">Input parameter AddWorkCellModel in a body, <see cref="AddWorkCellModel"/></param>
        /// <returns>If success should return newly added WorkCellModel <see cref="WorkCellModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddWorkCellModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update workcell configuration
        /// </summary>
        /// <param name="id">WorkCell Id as input in URL</param>
        /// <param name="request">Input parameter UpdateWorkCellModel in a body, <see cref="UpdateWorkCellModel"/></param>
        /// <returns>If success should return newly added WorkCellModel <see cref="WorkCellModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateWorkCellModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete workcell configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteWorkCellModel in a body, <see cref="DeleteWorkCellModel"/></param>
        /// <returns>If success should return newly added DeleteWorkCellResponse <see cref="DeleteWorkCellResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminWorkCellCanDelete))]
        public async Task<IActionResult> Delete(DeleteWorkCellModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
    }
}
