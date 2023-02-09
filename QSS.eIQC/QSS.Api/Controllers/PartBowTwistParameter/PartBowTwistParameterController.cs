/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartBowTwistParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PartBowTwistParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PartBowTwistParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PartBowTwistParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public PartBowTwistParameterController(ILogger<PartBowTwistParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new PartBowTwistParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddPartBowTwistParameterModel in a body, <see cref="AddPartInspectionBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added PartBowTwistParameterModel <see cref="PartBowTwistParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPartBowTwistParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPartInspectionBowTwistParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update PartBowTwistParameter configuration
        /// </summary>
        /// <param name="id">PartBowTwistParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePartBowTwistParameterModel in a body, <see cref="UpdatePartInspectionBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added PartBowTwistParameterModel <see cref="PartBowTwistParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartBowTwistParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePartInspectionBowTwistParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete PartBowTwistParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeletePartBowTwistParameterModel in a body, <see cref="DeletePartInspectionBowTwistParameterModel"/></param>
        /// <returns>If success should return newly added DeletePartBowTwistParameterResponse <see cref="DeletePartInspectionBowTwistParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartBowTwistParameterCanDelete))]
        public async Task<IActionResult> Delete(DeletePartInspectionBowTwistParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}