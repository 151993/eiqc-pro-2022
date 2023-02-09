using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Update;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Delete;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ParameterTypeCode Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ParameterTypeCodeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ParameterTypeCodeController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ParameterTypeCodeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public ParameterTypeCodeController(ILogger<ParameterTypeCodeController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new ParameterTypeCode configuration
        /// </summary>
        /// <param name="request">Input parameter AddParameterTypeCodeModel in a body, <see cref="AddParameterTypeCodeModel"/></param>
        /// <returns>If success should return newly added ParameterTypeCodeModel <see cref="ParameterTypeCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCodeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddParameterTypeCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ParameterTypeCode configuration
        /// </summary>
        /// <param name="id">ParameterTypeCode Id as input in URL</param>
        /// <param name="request">Input parameter UpdateParameterTypeCodeModel in a body, <see cref="UpdateParameterTypeCodeModel"/></param>
        /// <returns>If success should return newly added ParameterTypeCodeModel <see cref="ParameterTypeCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCodeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateParameterTypeCodeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ParameterTypeCode configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteParameterTypeCodeModel in a body, <see cref="DeleteParameterTypeCodeModel"/></param>
        /// <returns>If success should return newly added DeleteParameterTypeCodeResponse <see cref="DeleteParameterTypeCodeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterTypeCodeCanDelete))]
        public async Task<IActionResult> Delete(DeleteParameterTypeCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}