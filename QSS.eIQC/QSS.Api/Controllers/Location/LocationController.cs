using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.LocationCommand;
using QSS.eIQC.Handlers.Commands.LocationCommand.Add;
using QSS.eIQC.Handlers.Commands.LocationCommand.Delete;
using QSS.eIQC.Handlers.Commands.LocationCommand.Update;
using QSS.Helpers.Http;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers.Location
{
    /// <summary>
    /// Location Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<LocationController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of LocationController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public LocationController(ILogger<LocationController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new Location configuration
        /// </summary>
        /// <param name="request">Input parameter AddLocationModel in a body, <see cref="AddLocationModel"/></param>
        /// <returns>If success should return newly added LocationModel <see cref="LocationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminLocationCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddLocationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Location configuration
        /// </summary>
        /// <param name="id">Location Id as input in URL</param>
        /// <param name="request">Input parameter UpdateLocationModel in a body, <see cref="UpdateLocationModel"/></param>
        /// <returns>If success should return newly added LocationModel <see cref="LocationModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminLocationCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateLocationModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Location configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteLocationModel in a body, <see cref="DeleteLocationModel"/></param>
        /// <returns>If success should return newly added DeleteLocationResponse <see cref="DeleteLocationResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminLocationCanDelete))]
        public async Task<IActionResult> Delete(DeleteLocationModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

    }
}
