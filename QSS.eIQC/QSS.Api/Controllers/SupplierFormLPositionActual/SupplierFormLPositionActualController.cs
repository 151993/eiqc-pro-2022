/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormLPositionActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormLPositionActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormLPositionActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormLPositionActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormLPositionActualController(ILogger<SupplierFormLPositionActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormLPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormLPositionActualModel in a body, <see cref="AddSupplierFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormLPositionActualModel <see cref="SupplierFormLPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormLPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormLPositionActual configuration
        /// </summary>
        /// <param name="id">SupplierFormLPositionActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormLPositionActualModel in a body, <see cref="UpdateSupplierFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormLPositionActualModel <see cref="SupplierFormLPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormLPositionActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormLPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormLPositionActualModel in a body, <see cref="DeleteSupplierFormLPositionActualModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormLPositionActualResponse <see cref="DeleteSupplierFormLPositionActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormLPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}