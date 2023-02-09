/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormMPositionActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormMPositionActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormMPositionActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormMPositionActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormMPositionActualController(ILogger<SupplierFormMPositionActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormMPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormMPositionActualModel in a body, <see cref="AddSupplierFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormMPositionActualModel <see cref="SupplierFormMPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormMPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormMPositionActual configuration
        /// </summary>
        /// <param name="id">SupplierFormMPositionActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormMPositionActualModel in a body, <see cref="UpdateSupplierFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormMPositionActualModel <see cref="SupplierFormMPositionActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormMPositionActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormMPositionActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormMPositionActualModel in a body, <see cref="DeleteSupplierFormMPositionActualModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormMPositionActualResponse <see cref="DeleteSupplierFormMPositionActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormMPositionActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}