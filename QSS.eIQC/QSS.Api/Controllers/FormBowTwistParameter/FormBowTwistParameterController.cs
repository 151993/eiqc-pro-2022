/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormBowTwistParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormBowTwistParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormBowTwistParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormBowTwistParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormBowTwistParameterController(ILogger<FormBowTwistParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormBowTwistParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormBowTwistParameterModel in a body, <see cref="AddFormBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added FormBowTwistParameterModel <see cref="FormBowTwistParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormBowTwistParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormBowTwistParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormBowTwistParameter configuration
        /// </summary>
        /// <param name="id">FormBowTwistParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormBowTwistParameterModel in a body, <see cref="UpdateFormBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added FormBowTwistParameterModel <see cref="FormBowTwistParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormBowTwistParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormBowTwistParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormBowTwistParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormBowTwistParameterModel in a body, <see cref="DeleteFormBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added DeleteFormBowTwistParameterResponse <see cref="DeleteFormBowTwistParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormBowTwistParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormBowTwistParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}