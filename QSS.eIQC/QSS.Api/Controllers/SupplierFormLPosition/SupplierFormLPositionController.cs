/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormLPositionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormLPosition Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormLPositionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormLPositionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormLPositionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormLPositionController(ILogger<SupplierFormLPositionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormLPosition configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormLPositionModel in a body, <see cref="AddSupplierFormLPositionModel"/></param>
        /// <returns>If success should return newly added SupplierFormLPositionModel <see cref="SupplierFormLPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormLPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormLPosition configuration
        /// </summary>
        /// <param name="id">SupplierFormLPosition Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormLPositionModel in a body, <see cref="UpdateSupplierFormLPositionModel"/></param>
        /// <returns>If success should return newly added SupplierFormLPositionModel <see cref="SupplierFormLPositionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormLPositionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormLPosition configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormLPositionModel in a body, <see cref="DeleteSupplierFormLPositionModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormLPositionResponse <see cref="DeleteSupplierFormLPositionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormLPositionCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormLPositionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}