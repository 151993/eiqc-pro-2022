/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormVISCommand.Add;
using QSS.eIQC.Handlers.Commands.FormVISCommand.Update;
using QSS.eIQC.Handlers.Commands.FormVISCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormVISCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormVIS Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormVISController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormVISController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormVISController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormVISController(ILogger<FormVISController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormVIS configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormVISModel in a body, <see cref="AddFormVISModel"/></param>
        /// <returns>If success should return newly added FormVISModel <see cref="FormVISModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormVISCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormVISModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormVIS configuration
        /// </summary>
        /// <param name="id">FormVIS Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormVISModel in a body, <see cref="UpdateFormVISModel"/></param>
        /// <returns>If success should return newly added FormVISModel <see cref="FormVISModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormVISCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormVISModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormVIS configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormVISModel in a body, <see cref="DeleteFormVISModel"/></param>
        /// <returns>If success should return newly added DeleteFormVISResponse <see cref="DeleteFormVISResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormVISCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormVISModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}