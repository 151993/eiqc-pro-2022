/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Update;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormBowTwistActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormBowTwistActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormBowTwistActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormBowTwistActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormBowTwistActualController(ILogger<SupplierFormBowTwistActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormBowTwistActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormBowTwistActualModel in a body, <see cref="AddSupplierFormBowTwistActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormBowTwistActualModel <see cref="SupplierFormBowTwistActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormBowTwistActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormBowTwistActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormBowTwistActual configuration
        /// </summary>
        /// <param name="id">SupplierFormBowTwistActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormBowTwistActualModel in a body, <see cref="UpdateSupplierFormBowTwistActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormBowTwistActualModel <see cref="SupplierFormBowTwistActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormBowTwistActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormBowTwistActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormBowTwistActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormBowTwistActualModel in a body, <see cref="DeleteSupplierFormBowTwistActualModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormBowTwistActualResponse <see cref="DeleteSupplierFormBowTwistActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormBowTwistActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormBowTwistActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}