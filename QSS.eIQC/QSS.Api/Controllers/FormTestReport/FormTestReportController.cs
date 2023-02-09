/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormTestReportCommand.Add;
using QSS.eIQC.Handlers.Commands.FormTestReportCommand.Update;
using QSS.eIQC.Handlers.Commands.FormTestReportCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormTestReportCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormTestReport Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormTestReportController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormTestReportController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormTestReportController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormTestReportController(ILogger<FormTestReportController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormTestReport configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormTestReportModel in a body, <see cref="AddFormTestReportModel"/></param>
        /// <returns>If success should return newly added FormTestReportModel <see cref="FormTestReportModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormTestReportCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormTestReportModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormTestReport configuration
        /// </summary>
        /// <param name="id">FormTestReport Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormTestReportModel in a body, <see cref="UpdateFormTestReportModel"/></param>
        /// <returns>If success should return newly added FormTestReportModel <see cref="FormTestReportModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormTestReportCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormTestReportModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormTestReport configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormTestReportModel in a body, <see cref="DeleteFormTestReportModel"/></param>
        /// <returns>If success should return newly added DeleteFormTestReportResponse <see cref="DeleteFormTestReportResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormTestReportCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormTestReportModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}