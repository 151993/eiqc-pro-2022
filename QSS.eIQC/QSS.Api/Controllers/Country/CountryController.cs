
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using QSS.eIQC.Handlers.Commands.CountryCommand.Delete;
using QSS.eIQC.Handlers.Commands.CountryCommand.Update;
using QSS.Helpers.Http;

namespace QSS.eIQC.Api.Controllers.Country
{
    /// <summary>
    /// Country Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CountryController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CountryController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public CountryController(ILogger<CountryController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new Country configuration
        /// </summary>
        /// <param name="request">Input parameter AddCountryModel in a body, <see cref="AddCountryModel"/></param>
        /// <returns>If success should return newly added CountryModel <see cref="CountryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCountryCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCountryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Country configuration
        /// </summary>
        /// <param name="id">Country Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCountryModel in a body, <see cref="UpdateCountryModel"/></param>
        /// <returns>If success should return newly added CountryModel <see cref="CountryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCountryCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCountryModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Country configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCountryModel in a body, <see cref="DeleteCountryModel"/></param>
        /// <returns>If success should return newly added DeleteCountryResponse <see cref="DeleteCountryResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCountryCanDelete))]
        public async Task<IActionResult> Delete(DeleteCountryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
    }
}
