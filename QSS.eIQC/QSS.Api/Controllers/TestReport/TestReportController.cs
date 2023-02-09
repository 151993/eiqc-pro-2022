/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.TestReportCommand.Add;
using QSS.eIQC.Handlers.Commands.TestReportCommand.Update;
using QSS.eIQC.Handlers.Commands.TestReportCommand.Delete;
using QSS.eIQC.Handlers.Commands.TestReportCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// TestReport Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class TestReportController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<TestReportController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of TestReportController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public TestReportController(ILogger<TestReportController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new TestReport configuration
        /// </summary>
        /// <param name="request">Input parameter AddTestReportModel in a body, <see cref="AddTestReportModel"/></param>
        /// <returns>If success should return newly added TestReportModel <see cref="TestReportModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminTestReportCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddTestReportModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update TestReport configuration
        /// </summary>
        /// <param name="id">TestReport Id as input in URL</param>
        /// <param name="request">Input parameter UpdateTestReportModel in a body, <see cref="UpdateTestReportModel"/></param>
        /// <returns>If success should return newly added TestReportModel <see cref="TestReportModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminTestReportCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateTestReportModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete TestReport configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteTestReportModel in a body, <see cref="DeleteTestReportModel"/></param>
        /// <returns>If success should return newly added DeleteTestReportResponse <see cref="DeleteTestReportResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminTestReportCanDelete))]
        public async Task<IActionResult> Delete(DeleteTestReportModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}