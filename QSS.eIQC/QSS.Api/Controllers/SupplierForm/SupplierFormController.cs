/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierForm Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormController(ILogger<SupplierFormController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierForm configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormModel in a body, <see cref="AddSupplierFormModel"/></param>
        /// <returns>If success should return newly added SupplierFormModel <see cref="SupplierFormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierForm configuration
        /// </summary>
        /// <param name="id">SupplierForm Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormModel in a body, <see cref="UpdateSupplierFormModel"/></param>
        /// <returns>If success should return newly added SupplierFormModel <see cref="SupplierFormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierForm configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormModel in a body, <see cref="DeleteSupplierFormModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormResponse <see cref="DeleteSupplierFormResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}