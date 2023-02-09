using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.RegionCommand;
using QSS.eIQC.Handlers.Commands.RegionCommand.Add;
using QSS.eIQC.Handlers.Commands.RegionCommand.Delete;
using QSS.eIQC.Handlers.Commands.RegionCommand.Update;
using QSS.Helpers.Http;
using System.Threading.Tasks;

namespace QSS.Controllers
{
    /// <summary>
    /// Region Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<RegionController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of RegionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public RegionController(ILogger<RegionController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new Region configuration
        /// </summary>
        /// <param name="request">Input parameter AddRegionModel in a body, <see cref="AddRegionModel"/></param>
        /// <returns>If success should return newly added RegionModel <see cref="RegionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminRegionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddRegionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update User configuration
        /// </summary>
        /// <param name="id">Region Id as input in URL</param>
        /// <param name="request">Input parameter UpdateRegionModel in a body, <see cref="UpdateRegionModel"/></param>
        /// <returns>If success should return newly added RegionModel <see cref="RegionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminRegionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRegionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Region configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteRegionModel in a body, <see cref="DeleteRegionModel"/></param>
        /// <returns>If success should return newly added DeleteRegionResponse <see cref="DeleteRegionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminRegionCanDelete))]
        public async Task<IActionResult> Delete(DeleteRegionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
       
    }
}