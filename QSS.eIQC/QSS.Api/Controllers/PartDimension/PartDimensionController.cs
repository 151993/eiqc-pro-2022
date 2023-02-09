/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Update;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Delete;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartDimension Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class PartDimensionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PartDimensionController> _logger;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of PartDimensionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public PartDimensionController(ILogger<PartDimensionController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new PartDimension configuration
        /// </summary>
        /// <param name="request">Input parameter AddPartDimensionModel in a body, <see cref="AddPartDimensionModel"/></param>
        /// <returns>If success should return newly added PartDimensionModel <see cref="PartDimensionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminPartDimensionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddPartDimensionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update PartDimension configuration
        /// </summary>
        /// <param name="id">PartDimension Id as input in URL</param>
        /// <param name="request">Input parameter UpdatePartDimensionModel in a body, <see cref="UpdatePartDimensionModel"/></param>
        /// <returns>If success should return newly added PartDimensionModel <see cref="PartDimensionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartDimensionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePartDimensionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete PartDimension configuration
        /// </summary>
        /// <param name="request">Input parameter DeletePartDimensionModel in a body, <see cref="DeletePartDimensionModel"/></param>
        /// <returns>If success should return newly added DeletePartDimensionResponse <see cref="DeletePartDimensionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminPartDimensionCanDelete))]
        public async Task<IActionResult> Delete(DeletePartDimensionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}