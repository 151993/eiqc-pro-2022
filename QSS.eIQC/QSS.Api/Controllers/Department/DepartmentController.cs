using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Delete;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Update;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.Controllers
{
    /// <summary>
    /// Department Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<DepartmentController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DepartmentController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public DepartmentController(ILogger<DepartmentController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Department configuration
        /// </summary>
        /// <param name="request">Input parameter AddDepartmentModel in a body, <see cref="AddDepartmentModel"/></param>
        /// <returns>If success should return newly added DepartmentModel <see cref="DepartmentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminDepartmentCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddDepartmentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update User configuration
        /// </summary>
        /// <param name="id">Department Id as input in URL</param>
        /// <param name="request">Input parameter UpdateDepartmentModel in a body, <see cref="UpdateDepartmentModel"/></param>
        /// <returns>If success should return newly added DepartmentModel <see cref="DepartmentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDepartmentCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDepartmentModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Department configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteDepartmentModel in a body, <see cref="DeleteDepartmentModel"/></param>
        /// <returns>If success should return newly added DeleteDepartmentResponse <see cref="DeleteDepartmentResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDepartmentCanDelete))]
        public async Task<IActionResult> Delete(DeleteDepartmentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
       
    }
}