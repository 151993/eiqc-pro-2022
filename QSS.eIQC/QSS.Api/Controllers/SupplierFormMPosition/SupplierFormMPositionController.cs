/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormMPosition Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormMPositionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormMPositionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormMPositionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormMPositionController(ILogger<SupplierFormMPositionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormMPosition configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormMPositionModel in a body, <see cref="AddSupplierFormMPositionModel"/></param>
        /// <returns>If success should return newly added SupplierFormMPositionModel <see cref="SupplierFormMPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormMPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormMPosition configuration
        /// </summary>
        /// <param name="id">SupplierFormMPosition Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormMPositionModel in a body, <see cref="UpdateSupplierFormMPositionModel"/></param>
        /// <returns>If success should return newly added SupplierFormMPositionModel <see cref="SupplierFormMPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormMPositionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormMPosition configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormMPositionModel in a body, <see cref="DeleteSupplierFormMPositionModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormMPositionResponse <see cref="DeleteSupplierFormMPositionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMPositionCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormMPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}